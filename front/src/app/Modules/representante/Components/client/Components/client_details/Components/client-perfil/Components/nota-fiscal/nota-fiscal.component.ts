import { Component, HostListener, OnInit } from '@angular/core';
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
    id = '';
    listGrid: INotaFiscal[] = [];
    paginate: PaginateShare;
    contentHeight: number;

    constructor(
    private _Activatedroute: ActivatedRoute,
    private service: ADVGFRPVService
    ) {
        this.contentHeight = 0;
        this.paginate = new PaginateShare();
        this._Activatedroute.paramMap.subscribe((params) => {
            this.id = params.get('id') as string;
        });
    }

    ngOnInit(): void {
        this.paginate.setHtml('#table_id_paginate');
        this.getAll();
        this.getSize();
    }

    getAll(page = 1, limit = 10) {
        this.service.GetAllNF(Number(this.id), page, limit).then((response) => {
            this.listGrid = response.data;
            this.paginate.setAttr(response);
            this.paginate.setPaginate((e: any) => {
                this.getAll(e.current, e.limit);
            });
        });
    }
  @HostListener('window:resize', ['$event'])
    getSize() {
        const doc = document.querySelector('#tab_3 > app-nota-fiscal > div > div');
        const contentHeight = doc?.clientHeight;

        this.contentHeight = contentHeight || 0;
        this.contentHeight -= 150;
        this.contentHeight = this.contentHeight < 0 ? 0 : this.contentHeight;
        if (document.body.clientWidth <= 768) {
            this.contentHeight -= 30;
        }
    }
}
