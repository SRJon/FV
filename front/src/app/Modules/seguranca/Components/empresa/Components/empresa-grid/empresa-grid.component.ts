import {
  Component,
  EventEmitter,
  Input,
  OnChanges,
  OnInit,
  Output,
} from '@angular/core';
import { Paginate } from 'src/app/Domain/Models/Paginate';
import { IEmpresa } from './../../../../../../Domain/Models/IEmpresa';
import { CompanyService } from 'src/app/Modules/seguranca/Services/company.service';
import { AlertsService } from 'src/app/Repository/Alerts/alerts.service';
import * as shareds from 'src/app/Shared';

@Component({
  selector: 'app-empresa-grid',
  templateUrl: './empresa-grid.component.html',
  styleUrls: ['./empresa-grid.component.scss'],
})
export class EmpresaGridComponent implements OnInit, OnChanges {
  @Input() listGrid: any[] = [];
  isShowing: boolean = false;
  @Input() paginate: Paginate;
  @Input() totalItems: number = 0;
  @Output() nextSelection = new EventEmitter<number>();
  selectedRecord: IEmpresa | undefined;
  isDelete: boolean = false;

  lastI = 0;

  listTitle: string[] = ['id', 'nome', 'vlrMinFrete', 'vlrMinPedido', 'codEmp'];
  listTitleGrid: string[] = [
    'Id',
    'Nome',
    'Valor do Frete Mínimo',
    'Valor do Pedido Mínimo',
    'Código da Empresa',
  ];

  grid: shareds.Grid;

  constructor(
    private companyService: CompanyService,
    private alertsService: AlertsService
  ) {
    this.grid = new shareds.Grid();
    this.lastI = this.listTitle.length + 1;
    this.paginate = new Paginate(2000, 50);
  }

  showGrid(show: boolean) {
    this.isShowing = show;
  }

  getTitle(t: string) {
    let index = this.listTitle.indexOf(t);
    return this.listTitleGrid[index];
  }

  clickOnPagination(page: number): void {
    this.nextSelection.emit(page);
  }

  getType(type: string): string {
    return (typeof type).trim();
  }

  stateModal(isClose: boolean): void {
    if (isClose) {
      this.selectedRecord = undefined;
    }
  }

  openModal(obj: IEmpresa | undefined = undefined): void {
    if (obj) {
      this.selectedRecord = this.listGrid.find((e) => e.id === obj.id);
    }
  }

  onDelete(obj: IEmpresa | undefined = undefined) {
    this.selectedRecord = obj;

    this.isDelete = true;
  }

  delete(id: number) {
    this.companyService
      .deleteCompany(id || 0)
      .then((res) => {
        this.clickOnPagination(this.paginate.currentPage);

        if (res.data) {
          this.alertsService.showAlert(
            'Empresa excluida com sucesso',
            'success'
          );
        } else {
          this.alertsService.showAlert('Erro ao excluir empresa', 'error');
        }
      })
      .catch((err) => {
        this.alertsService.showAlert(
          `Erro ao excluir empresa --- ${err.message}`,
          'error'
        );
      })
      .finally(() => {
        this.isDelete = false;
        this.selectedRecord = undefined;
      });
  }

  onModalClose(isClose: boolean) {
    if (isClose) {
      this.selectedRecord = undefined;
      this.isDelete = false;
    } else {
      if (this.selectedRecord) {
        this.delete(this.selectedRecord.id || 0);
      }
    }
  }

  ngOnInit(): void {
    this.initGrid();
  }

  initGrid(): void {
    this.grid.createGrid({ selectorHtml: '#table_id', paging: false });
  }
  setPaginate(): void {
    this.grid.sharePaginate.setHtml('#table_id_paginate');
    this.grid.sharePaginate.paginate = this.paginate;
    this.grid.sharePaginate.setPaginate((e: any) => {
      this.clickOnPagination(e);
    });
    this.grid.render();
  }
  ngOnChanges(): void {
    this.setPaginate();
  }

  gridEvents() {
    let inter = setInterval(() => {
      if ($('td').length > 0) {
        $('td').hover((e) => {
          let index = $(e.target).index();
          index++;

          let tds = $(`td[data-column=column${index}]`);
          tds.toggleClass('hov-column-ver5');

          let childrens = e.currentTarget.parentElement?.children;

          if (childrens) {
            let ch = $(childrens);
            ch.toggleClass('hov-column-ver5');
          }
        });
        clearInterval(inter);
      }
    }, 100);
  }

  toNumber(value: any, t: any, isTitle: boolean = false) {
    return Number(value) + Number(t);
  }
}
