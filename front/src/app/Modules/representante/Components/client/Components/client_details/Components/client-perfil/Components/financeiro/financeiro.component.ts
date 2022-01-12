import { Component, HostListener, OnInit } from '@angular/core';
import { INotaFinanceiro } from 'src/app/Domain/Models/NotaFinanceiro';
import { ADVGFRPVService } from 'src/app/Modules/representante/Services/AD_VGFRPV/ad-vgfrpv.service';
import { PaginateShare } from 'src/app/Shared';

@Component({
  selector: 'app-financeiro',
  templateUrl: './financeiro.component.html',
  styleUrls: ['./financeiro.component.scss'],
})
export class FinanceiroComponent implements OnInit {
  listGrid: INotaFinanceiro[] = [];
  contentHeight = 0;
  paginate: PaginateShare;

  constructor(private services: ADVGFRPVService) {
    this.paginate = new PaginateShare();
    this.listGrid = [];
  }

  ngOnInit(): void {
    this.paginate.setHtml('#table_id_paginate');
    this.getAll(
      this.paginate.paginate.currentPage,
      this.paginate.paginate.limit
    );
    this.getSize();
  }
  getAll(page: number, limit: number) {
    this.services.GetAllFinanceiro(3734, page, limit).then((res) => {
      this.listGrid = res.data;
      this.paginate.setAttr(res);
      this.paginate.setPaginate(
        (e: { current: number; length: number; total: number }) =>
          this.getAll(e.current, e.length)
      );
    });
  }
  @HostListener('window:resize', ['$event'])
  getSize() {
    const doc = document.querySelector('#tab_5');
    const contentHeight = doc?.clientHeight;

    this.contentHeight = contentHeight || 0;
    this.contentHeight -= 150;
    this.contentHeight = this.contentHeight < 0 ? 0 : this.contentHeight;
    if (document.body.clientWidth <= 768) {
      this.contentHeight -= 30;
    }
  }
}
