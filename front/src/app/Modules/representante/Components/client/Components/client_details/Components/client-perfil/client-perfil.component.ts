import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { Pedido } from 'src/app/Domain/Models/IPedido';
import { ADVGFRPVService } from 'src/app/Modules/representante/Services/AD_VGFRPV/ad-vgfrpv.service';
import { PaginateShare } from 'src/app/Shared';

@Component({
    selector: 'app-client-perfil',
    templateUrl: './client-perfil.component.html',
    styleUrls: ['./client-perfil.component.scss'],
})
export class ClientPerfilComponent implements OnInit {
    data: { value: string; key: string }[] = [];
    id = '';
    listGrid: Pedido[] = [];
    size = 0;
    paginate: PaginateShare;

    constructor(
    private services: ADVGFRPVService,
    private _Activatedroute: ActivatedRoute
    ) {
        this.paginate = new PaginateShare();
    }

    ngOnInit(): void {
        this.paginate.setHtml('#table_id_paginate');

        this._Activatedroute.paramMap.subscribe((params) => {
            this.id = params.get('id') as string;
            if (this.id) {
                this.getAll(
                    this.paginate.paginate.currentPage,
                    this.paginate.paginate.limit
                );
            }
        });
    }

    onChange(m: { value: string; key: string }[]) {
        this.data = m;
    }
    onResized(m: number) {
        this.size = m;
        if (document.body.clientWidth <= 768) {
            this.paginate.setEnabePageNumbers(false);
        } else {
            this.paginate.setEnabePageNumbers(true);
        }
    }

    getAll(page: number, limit: number) {
        this.services
            .GetAllByCodParc(Number(this.id), page, limit)
            .then((result) => {
                this.listGrid = result.data;
                this.paginate.setAttr(result);
                this.paginate.setPaginate(
                    (e: { current: number; length: number; total: number }) =>
                        this.getAll(e.current, e.length)
                );
            });
    }
}
