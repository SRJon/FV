import {
  Component,
  EventEmitter,
  Input,
  OnChanges,
  OnInit,
  Output,
} from '@angular/core';
import { IPerfil } from 'src/app/Domain/Models/IPerfil';
import { Paginate } from 'src/app/Domain/Models/Paginate';
import { PerfilService } from 'src/app/Modules/seguranca/Services/perfil.service';
import { AlertsService } from 'src/app/Repository/Alerts/alerts.service';
import * as shareds from 'src/app/Shared';

@Component({
  selector: 'app-perfil-grid',
  templateUrl: './perfil-grid.component.html',
  styleUrls: ['./perfil-grid.component.scss'],
})
export class PerfilGridComponent implements OnInit, OnChanges {
  @Input() listGrid: any[] = [];
  isShowing = false;
  @Input() paginate: Paginate;
  @Input() totalItems = 0;
  @Output() nextSelection = new EventEmitter<number>();
  selectedRecord: IPerfil | undefined;
  isDelete = false;

  lastI = 0;

  listTitle: string[] = ['id', 'nome', 'peR_COD'];
  listTitleGrid: string[] = ['Id', 'Nome', 'Grupo'];

  grid: shareds.Grid;

  constructor(
    private perfilService: PerfilService,
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
    const index = this.listTitle.indexOf(t);
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

  openModal(obj: IPerfil | undefined = undefined): void {
    if (obj) {
      this.selectedRecord = this.listGrid.find((e) => e.id === obj.id);
    }
  }

  onDelete(obj: IPerfil | undefined = undefined) {
    this.selectedRecord = obj;

    this.isDelete = true;
  }

  delete(id: number) {
    this.perfilService
      .deletePerfil(id || 0)
      .then((res) => {
        this.clickOnPagination(this.paginate.currentPage);

        if (res.data) {
          this.alertsService.showAlert(
            'Perfil excluido com sucesso',
            'success'
          );
        } else {
          this.alertsService.showAlert('Erro ao excluir o perfil', 'error');
        }
      })
      .catch((err) => {
        this.alertsService.showAlert(
          `Erro ao excluir perfil --- ${err.message}`,
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
    const inter = setInterval(() => {
      if ($('td').length > 0) {
        $('td').hover((e) => {
          let index = $(e.target).index();
          index++;

          const tds = $(`td[data-column=column${index}]`);
          tds.toggleClass('hov-column-ver5');

          const childrens = e.currentTarget.parentElement?.children;

          if (childrens) {
            const ch = $(childrens);
            ch.toggleClass('hov-column-ver5');
          }
        });
        clearInterval(inter);
      }
    }, 100);
  }

  toNumber(value: any, t: any, isTitle = false) {
    return Number(value) + Number(t);
  }
}
