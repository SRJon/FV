import {
  Component,
  EventEmitter,
  Input,
  OnChanges,
  OnInit,
  Output,
} from '@angular/core';
import { ScreensService } from 'src/app/Modules/seguranca/Services/screens.service';
import { ITela } from '../../../../../../Domain/Models/ITela';
import { Paginate } from '../../../../../../Domain/Models/Paginate';

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
  async onDelete(obj: ITela | undefined = undefined): Promise<void> {
    if (obj) {
      this.screensService
        .deleteScreen(obj.id || 0)
        .then((res) => {
          console.log(res, 'res');
        })
        .catch((err) => {
          console.log(err, 'ress');
        });
    }
  }

  constructor(private screensService: ScreensService) {
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

  ngOnInit(): void {
    this.initGrid();
  }

  initGrid(): void {
    let ctx = this;
    $(document).ready(function () {
      // @ts-ignore: Unreachable code error

      $('#table_id').dataTable({
        paging: false,
        lengthChange: false,
        info: '',
      });

      ctx.setPaginate(ctx);
    });
  }
  setPaginate(ctx: this): void {
    // @ts-ignore: Unreachable code error
    $('#table_id_paginate').pagination({
      total: ctx.paginate.pageSize * 10,
      current: ctx.paginate.currentPage,
      click: function (e: any) {
        // ctx.paginate.currentPage = e.current;
        ctx.clickOnPagination(e.current);
      },
    });
  }
  ngOnChanges(): void {
    this.setPaginate(this);
  }
}
