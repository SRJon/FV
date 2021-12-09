import { Component, EventEmitter, Input, OnInit, Output } from '@angular/core';
import { IDiretorio } from 'src/app/Domain/Models/IDiretorio';
import { Paginate } from 'src/app/Domain/Models/Paginate';
import { AlertsService } from 'src/app/Repository/Alerts/alerts.service';
import * as shareds from 'src/app/Shared';
import { DirectoryService } from '../../../../Services/directory.service';

@Component({
  selector: 'app-diretorio-grid',
  templateUrl: './diretorio-grid.component.html',
  styleUrls: ['./diretorio-grid.component.scss'],
})
export class DiretorioGridComponent implements OnInit {
  @Input() listGrid: any[] = [];
  titleList: string[] = [];
  titleListGrid: string[] = [];
  @Input() paginate: Paginate;
  @Input() totalItems: number = 0;
  @Output() nextSelection = new EventEmitter<number>();
  selectedRecord: IDiretorio | undefined;
  isDelete: boolean = false;
  grid: shareds.Grid;

  constructor(
    private directoryService: DirectoryService,
    private alertsService: AlertsService
  ) {
    this.titleList = ['id', 'tipo', 'link', 'virtual'];
    this.titleListGrid = ['Id', 'Tipo', 'link', 'virtual'];
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
  openModal(obj: IDiretorio | undefined = undefined): void {
    if (obj) {
      this.selectedRecord = this.listGrid.find((e) => e.id === obj.id);
    }
  }
  onDelete(obj: IDiretorio | undefined = undefined) {
    this.selectedRecord = obj;

    this.isDelete = true;
  }
  delete(id: number) {
    this.directoryService
      .deleteDirectory(id || 0)
      .then((res) => {
        this.clickOnPagination(this.paginate.currentPage);

        if (res.data) {
          this.alertsService.showAlert(
            'Diretório excluido com sucesso',
            'success'
          );
        } else {
          this.alertsService.showAlert('Erro ao excluir diretório', 'error');
        }
      })
      .catch((err) => {
        this.alertsService.showAlert(
          `Erro ao excluir diretório --- ${err.message}`,
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