import {
  Component,
  EventEmitter,
  Input,
  OnChanges,
  OnInit,
  Output,
} from '@angular/core';
import { IParametro } from 'src/app/Domain/Models/IParametro';
import { Paginate } from 'src/app/Domain/Models/Paginate';
import { ParameterService } from 'src/app/Modules/seguranca/Services/parameter.service';
import { AlertsService } from 'src/app/Repository/Alerts/alerts.service';
import * as shareds from 'src/app/Shared';

@Component({
  selector: 'app-parametro-grid',
  templateUrl: './parametro-grid.component.html',
  styleUrls: ['./parametro-grid.component.scss'],
})
export class ParametroGridComponent implements OnInit, OnChanges {
  @Input() listGrid: any[] = [];
  titleList: string[] = [];
  titleListGrid: string[] = [];
  @Input() paginate: Paginate;
  @Input() totalItems: number = 0;
  @Output() nextSelection = new EventEmitter<number>();
  selectedRecord: IParametro | undefined;
  isDelete: boolean = false;
  grid: shareds.Grid;

  constructor(
    private parameterService: ParameterService,
    private alertsService: AlertsService
  ) {
    this.titleList = ['id', 'nome', 'valor', 'descricao'];
    this.titleListGrid = ['Id', 'Nome', 'Valor', 'Descrição'];
    this.grid = new shareds.Grid();
    this.paginate = new Paginate(2000, 50);
  }
  getTitle(t: string) {
    let index = this.titleList.indexOf(t);

    return this.titleListGrid[index];
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
  openModal(obj: IParametro | undefined = undefined): void {
    if (obj) {
      this.selectedRecord = this.listGrid.find((e) => e.id === obj.id);
    }
  }
  onDelete(obj: IParametro | undefined = undefined) {
    this.selectedRecord = obj;

    this.isDelete = true;
  }
  delete(id: number) {
    this.parameterService
      .deleteParameter(id || 0)
      .then((res) => {
        this.clickOnPagination(this.paginate.currentPage);

        if (res.data) {
          this.alertsService.showAlert(
            'Parametro excluida com sucesso',
            'success'
          );
        } else {
          this.alertsService.showAlert('Erro ao excluir parametro', 'error');
        }
      })
      .catch((err) => {
        this.alertsService.showAlert(
          `Erro ao excluir parametro --- ${err.message}`,
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
    this.grid.sharePaginate.setPaginate((e) => {
      this.clickOnPagination(e);
    });
    this.grid.render();
  }
  ngOnChanges(): void {
    this.setPaginate();
  }
}
