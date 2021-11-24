import {
  Component,
  EventEmitter,
  Input,
  OnChanges,
  OnInit,
  Output,
} from '@angular/core';
import { ScreensService } from 'src/app/Modules/seguranca/Services/screens.service';
import { AlertsService } from 'src/app/Repository/Alerts/alerts.service';
import { ITela } from '../../../../../../Domain/Models/ITela';
import { Paginate } from '../../../../../../Domain/Models/Paginate';
import * as shareds from 'src/app/Shared';

@Component({
  selector: 'app-tela-grid',
  templateUrl: './tela-grid.component.html',
  styleUrls: ['./tela-grid.component.scss'],
})
export class TelaGridComponent implements OnInit, OnChanges {
  @Input() listGrid: any[] = [];
  titleList: string[] = [];
  @Input() paginate: Paginate;
  @Input() totalItems: number = 0;
  @Output() nextSelection = new EventEmitter<number>();
  selectedRecord: ITela | undefined;
  isDelete: boolean = false;
  grid: shareds.Grid;

  constructor(
    private screensService: ScreensService,
    private alertsService: AlertsService
  ) {
    this.grid = new shareds.Grid();
    this.paginate = new Paginate(2000, 50);

    this.titleList = [
      'id',
      'nome',
      'url',
      'target',
      'nivel',
      'ordem',
      'modulo',
    ];
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
  openModal(obj: ITela | undefined = undefined): void {
    if (obj) {
      this.selectedRecord = this.listGrid.find((e) => e.id === obj.id);
    }
  }
  onDelete(obj: ITela | undefined = undefined) {
    this.selectedRecord = obj;

    this.isDelete = true;
  }
  delete(id: number) {
    this.screensService
      .deleteScreen(id || 0)
      .then((res) => {
        this.clickOnPagination(this.paginate.currentPage);

        if (res.data) {
          this.alertsService.showAlert('Tela excluida com sucesso', 'success');
        } else {
          this.alertsService.showAlert('Erro ao excluir tela', 'error');
        }
      })
      .catch((err) => {
        this.alertsService.showAlert(
          `Erro ao excluir tela --- ${err.message}`,
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
    this.grid.createGrid({ selectorHtml: '#table_id', paging: false }, this);
  }
  setPaginate(ctx: this): void {
    // @ts-ignore: Unreachable code error
    // $('#table_id_paginate').pagination({
    //   total: ctx.paginate.pageSize * 10,
    //   current: ctx.paginate.currentPage,
    //   click: function (e: any) {
    //     // ctx.paginate.currentPage = e.current;
    //     ctx.clickOnPagination(e.current);
    //   },
    // });
    this.grid.sharePaginate.setHtml('#table_id_paginate');
    this.grid.sharePaginate.paginate = this.paginate;
    console.log(this.paginate);

    this.grid.sharePaginate.setPaginate((e) => {
      console.log(e);
    });
  }
  ngOnChanges(): void {
    this.setPaginate(this);
  }
}