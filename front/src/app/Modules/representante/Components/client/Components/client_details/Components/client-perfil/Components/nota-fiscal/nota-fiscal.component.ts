import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { INotaFiscal } from 'src/app/Domain/Models/INotaFiscal';
import { ADVGFRPVService } from 'src/app/Modules/representante/Services/AD_VGFRPV/ad-vgfrpv.service';
import { PaginateShare } from 'src/app/Shared';

@Component({
  selector: 'app-nota-fiscal',
  templateUrl: './nota-fiscal.component.html',
  styleUrls: ['./nota-fiscal.component.scss'],
})
export class NotaFiscalComponent implements OnInit {
  id: string = '';
  listGrid: INotaFiscal[] = [];
  paginate: PaginateShare;

  constructor(
    private _Activatedroute: ActivatedRoute,
    private service: ADVGFRPVService
  ) {
    this.paginate = new PaginateShare();
    this._Activatedroute.paramMap.subscribe((params) => {
      this.id = params.get('id') as string;
    });
  }

  ngOnInit(): void {
    this.paginate.setHtml('#table_id_paginate');
    this.getAll();
  }

  getAll(page: number = 1, limit = 10) {
    this.service.GetAllNF(Number(this.id), page, limit).then((response) => {
      this.listGrid = response.data;
      this.paginate.setAttr(response);
      this.paginate.setPaginate((e: any) => {
        this.getAll(e.current, e.limit);
      });
    });
  }
}
