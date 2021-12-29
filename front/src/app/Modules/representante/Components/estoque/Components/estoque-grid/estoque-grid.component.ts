import { StockService } from './../../../../Services/stock.service';
import {
  Component,
  EventEmitter,
  Input,
  OnChanges,
  OnInit,
  Output,
} from '@angular/core';
import { IResponse } from 'src/app/Domain/Models/IResponse';
import { ITGFGRU } from 'src/app/Domain/Models/ITGFGRU';
import { ITGFRGV } from 'src/app/Domain/Models/ITGFRGV';
import { IUser } from 'src/app/Domain/Models/IUser';
import { UserGlobal } from 'src/app/Shared';
import { IAD_ESTCODPROD } from 'src/app/Domain/Models/IAD_ESTCODPROD';
import { Paginate } from 'src/app/Domain/Models/Paginate';
import * as shareds from 'src/app/Shared';
import { AlertsService } from 'src/app/Repository/Alerts/alerts.service';
import { AuthenticationService } from 'src/app/Modules/login/Services/Authentication.service';
@Component({
  selector: 'app-estoque-grid',
  templateUrl: './estoque-grid.component.html',
  styleUrls: ['./estoque-grid.component.scss'],
})
export class EstoqueGridComponent implements OnInit, OnChanges {
  vendGrpPrd: IResponse<ITGFRGV[]>;
  selectGrpPrd: ITGFGRU[] = [];
  selectedGrpPrd!: ITGFGRU;

  isShowing: boolean = false;

  @Input() listGrid: any[] = [];
  @Input() paginate: Paginate;
  @Input() totalItems: number = 0;
  @Output() nextSelection = new EventEmitter<number>();

  selectedRecord: IAD_ESTCODPROD | undefined;
  currentUser!: IUser;

  isDetail: boolean = false;

  lastI = 0;

  listTitle: string[] = [
    'produto',
    'codgrupoprod',
    'aD_CODANT',
    'codvol',
    'descrprod',
    'compldesc',
    'percentual',
  ];
  listGridTitle: string[] = [
    'Produto',
    'Grupo de Produto',
    'Código Anterior',
    'Volume',
    'Descrição',
    'Complemento',
    'Percentual',
  ];

  grid: shareds.Grid;

  constructor(
    private userG: UserGlobal<IUser>,
    private StockService: StockService,
    private alertsService: AlertsService
  ) {
    this.vendGrpPrd = {} as IResponse<ITGFRGV[]>;

    this.grid = new shareds.Grid();
    this.paginate = new Paginate(2000, 50);
  }

  initGrid(): void {
    this.grid.createGrid({ selectorHtml: '#table_id', paging: false });
  }

  async ngOnInit(): Promise<void> {
    this.initGrid();

    //Método utilizado para salvar os dados do usuário globalmente
    this.currentUser = await AuthenticationService.getGlobalUser();

    if (this.currentUser.vendedorUCod) {
      this.getGrupoProduto(this.currentUser.vendedorUCod);
    }
  }

  getGrupoProduto(codVend: number) {
    this.StockService.getCodGrupoProd(codVend).then((response) => {
      if (response.data) {
        this.selectGrpPrd = response.data.map((e) => e.tgfgru);
      }
    });
  }

  showGrid(show: boolean) {
    this.isShowing = show;
  }

  getTitle(t: string) {
    let index = this.listTitle.indexOf(t);
    return this.listGridTitle[index];
  }

  onChange(selectGrpPrd: ITGFGRU) {
    this.selectedGrpPrd = selectGrpPrd;
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

  openModal(obj: IAD_ESTCODPROD | undefined = undefined): void {
    if (obj) {
      this.selectedRecord = this.listGrid.find(
        (e) => e.produto === obj.produto
      );
    }
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

  onDetail(obj: IAD_ESTCODPROD | undefined): void {
    this.selectedRecord = obj;
    alert(obj);
  }
}
