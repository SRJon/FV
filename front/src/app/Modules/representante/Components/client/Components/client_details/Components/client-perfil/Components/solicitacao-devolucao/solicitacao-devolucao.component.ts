import { Component, HostListener, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { ISolicitacaoDevolucao } from 'src/app/Domain/Models/ISolicitacaoDevolucao';
import { ADVGFRPVService } from 'src/app/Modules/representante/Services/AD_VGFRPV/ad-vgfrpv.service';

@Component({
    selector: 'app-solicitacao-devolucao',
    templateUrl: './solicitacao-devolucao.component.html',
    styleUrls: ['./solicitacao-devolucao.component.scss'],
})
export class SolicitacaoDevolucaoComponent implements OnInit {
    id = '';
    listGrid: ISolicitacaoDevolucao[];
    contentHeight = 0;

    constructor(
    private service: ADVGFRPVService,
    private _Activatedroute: ActivatedRoute
    ) {
        this.listGrid = [];
        this._Activatedroute.paramMap.subscribe((params) => {
            this.id = params.get('id') as string;
        });
    }

    ngOnInit(): void {
        this.getAll(Number(this.id));
        this.getSize();
    }

    getAll(codparc: number, page = 1, limit = 10) {
        this.service
            .GetSolicitacaoDevolucao(codparc, page, limit)
            .then((response) => {
                // this.data.parceiro = response.data;
                this.listGrid = response.data.sort((a, b) => b.nusoldev - a.nusoldev);
            });
    }

  @HostListener('window:resize', ['$event'])
    getSize() {
        const doc = document.querySelector('#tab_4');
        const contentHeight = doc?.clientHeight;

        this.contentHeight = contentHeight || 0;
        this.contentHeight -= 100;
        this.contentHeight = this.contentHeight < 0 ? 0 : this.contentHeight;
        if (document.body.clientWidth <= 768) {
            this.contentHeight -= 30;
        }
    }
}
