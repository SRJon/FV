import { Component, EventEmitter, Input, OnInit, Output } from '@angular/core';
import { IUser } from 'src/app/Domain/Models/IUser';
import { Paginate } from 'src/app/Domain/Models/Paginate';
import { UserService } from 'src/app/Modules/seguranca/Services/user.service';
import { AlertsService } from 'src/app/Repository/Alerts/alerts.service';
import * as shareds from 'src/app/Shared';

@Component({
  selector: 'app-usuario-grid',
  templateUrl: './usuario-grid.component.html',
  styleUrls: ['./usuario-grid.component.scss'],
})
export class UsuarioGridComponent implements OnInit {
  @Input() listGrid: any[] = [];
  isShowing: boolean = false;
  @Input() paginate: Paginate;
  @Input() totalItems: number = 0;
  @Output() nextSelection = new EventEmitter<number>();
  selectedRecord: IUser | undefined;
  isDelete: boolean = false;

  lastI = 0;

  listTitle: string[] = ['id', 'nome', 'email', 'ativo'];
  listTitleGrid: string[] = ['Id', 'Tipo', 'Email', 'Ativo'];

  grid: shareds.Grid;

  constructor(
    private userService: UserService,
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

  openModal(obj: IUser | undefined = undefined): void {
    if (obj) {
      this.selectedRecord = this.listGrid.find((e) => e.id === obj.id);
    }
  }

  onDelete(obj: IUser | undefined = undefined) {
    this.selectedRecord = obj;

    this.isDelete = true;
  }

  delete(id: number) {
    this.userService
      .deleteUser(id || 0)
      .then((res) => {
        this.clickOnPagination(this.paginate.currentPage);

        if (res.data) {
          this.alertsService.showAlert(
            'Diret??rio excluido com sucesso',
            'success'
          );
        } else {
          this.alertsService.showAlert('Erro ao excluir diret??rio', 'error');
        }
      })
      .catch((err) => {
        this.alertsService.showAlert(
          `Erro ao excluir diret??rio --- ${err.message}`,
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
