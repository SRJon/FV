import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { ADVGFRPVService } from 'src/app/Modules/representante/Services/AD_VGFRPV/ad-vgfrpv.service';

@Component({
  selector: 'app-solicitacao-devolucao',
  templateUrl: './solicitacao-devolucao.component.html',
  styleUrls: ['./solicitacao-devolucao.component.scss'],
})
export class SolicitacaoDevolucaoComponent implements OnInit {
  id: string = '';

  constructor(
    private service: ADVGFRPVService,
    private _Activatedroute: ActivatedRoute
  ) {
    this._Activatedroute.paramMap.subscribe((params) => {
      this.id = params.get('id') as string;
    });
  }

  ngOnInit(): void {
    this.getAll(Number(this.id));
  }

  getAll(codparc: number, page: number = 1, limit: number = 10) {
    this.service
      .GetSolicitacaoDevolucao(codparc, page, limit)
      .then((response) => {
        // this.data.parceiro = response.data;
        console.log(response.data);
      });
  }
}
