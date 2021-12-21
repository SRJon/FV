import { StockService } from './../../../../Services/stock.service';
import { Component, OnInit } from '@angular/core';
import { Title } from '@angular/platform-browser';
import { IResponse } from 'src/app/Domain/Models/IResponse';
import { ITGFGRU } from 'src/app/Domain/Models/ITGFGRU';
import { ITGFRGV } from 'src/app/Domain/Models/ITGFRGV';
import { IUser } from 'src/app/Domain/Models/IUser';
import { UserGlobal } from 'src/app/Shared';

@Component({
  selector: 'app-estoque-grid',
  templateUrl: './estoque-grid.component.html',
  styleUrls: ['./estoque-grid.component.scss'],
})
export class EstoqueGridComponent implements OnInit {
  vendGrpPrd: IResponse<ITGFRGV[]>;
  grpPrd: ITGFGRU[] = [];
  selectedGrpPrd!: ITGFGRU;

  constructor(
    private userG: UserGlobal<IUser>,
    private StockService: StockService
  ) {
    this.vendGrpPrd = {} as IResponse<ITGFRGV[]>;
  }

  ngOnInit(): void {
    this.userG.getObservable().subscribe((user) => {
      let codVend = user.vendedorUCod;

      //Se existir um códdido de vendedor do Sankhya é realiza a consulta aos grupo de produtos relacionados ao vendedor
      if (codVend) {
        this.getGrupoProduto(codVend);
      }
    });
  }

  getGrupoProduto(codVend: number) {
    this.StockService.getCodGrupoProd(codVend).then((response) => {
      if (response.data) {
        this.grpPrd = response.data.map((e) => e.tgfgru);
      }
    });
  }

  onChange(grpPrd: ITGFGRU) {
    this.selectedGrpPrd = grpPrd;
  }
}
