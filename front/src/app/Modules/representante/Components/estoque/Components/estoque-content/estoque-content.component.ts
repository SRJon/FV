import { ITGFRGV } from 'src/app/Domain/Models/ITGFRGV';
import { Component, OnInit } from '@angular/core';
import { IAD_ESTCODPROD } from 'src/app/Domain/Models/IAD_ESTCODPROD';
import { IResponse } from 'src/app/Domain/Models/IResponse';
import { Paginate } from 'src/app/Domain/Models/Paginate';
import { StockService } from 'src/app/Modules/representante/Services/stock.service';

@Component({
  selector: 'app-estoque-content',
  templateUrl: './estoque-content.component.html',
  styleUrls: ['./estoque-content.component.scss'],
})
export class EstoqueContentComponent implements OnInit {
  estoques: IResponse<IAD_ESTCODPROD[]>;
  paginate: Paginate;
  isOpen: boolean = false;
  initialParam: IAD_ESTCODPROD = {} as IAD_ESTCODPROD;

  produto: number = -1;
  codgrupoprod: number = -1;
  descrprod: string = '';
  compldesc: string = '';

  constructor(private stockService: StockService) {
    this.estoques = {} as IResponse<IAD_ESTCODPROD[]>;
    this.paginate = new Paginate(1, 1);

    this.initialParam = {
      produto: 0,
      codgrupoprod: 0,
      descrgrupoprod: '',
      aD_CODANT: '',
      codvol: '',
      descrprod: '',
      compldesc: '',
      aD_LARGURATECIDO: 0,
      aD_GRAMATURA: 0,
      ncm: '',
      percentual: 0,
    };
  }
  ngOnInit(): void {
    this.getAll(
      1,
      10,
      this.produto,
      this.codgrupoprod,
      this.descrprod,
      this.compldesc
    );
  }

  openModal(isClose: boolean) {
    this.isOpen = !isClose;
    if (isClose) {
      this.getAll(
        this.paginate.currentPage,
        10,
        this.produto,
        this.codgrupoprod,
        this.descrprod,
        this.compldesc
      );
    }
  }
  getAll(
    page: number,
    limit: number = 10,
    Produto: number = -1,
    CodGrupoProd: number = -1,
    DescrProd: string,
    ComplDesc: string
  ) {
    this.stockService
      .getAdEstCodProd(page, limit, Produto, CodGrupoProd, DescrProd, ComplDesc)
      .then((response) => {
        this.estoques = response;
        this.paginate.pageSize = response.totalPages;
        this.paginate.totalItems = response.totalPages * limit;
        this.paginate.setPage();
      });
  }

  onNextSelection(page: number) {
    this.paginate.currentPage = page;
    this.getAll(
      page,
      10,
      this.produto,
      this.codgrupoprod,
      this.descrprod,
      this.compldesc
    );
  }
  ProdutoFilter(produto: number) {
    //~~ => converte string para int
    if (~~produto > 0) {
      this.getAll(
        1,
        10,
        produto,
        this.codgrupoprod,
        this.descrprod,
        this.compldesc
      );
    } else {
      this.getAll(
        1,
        10,
        this.produto,
        this.codgrupoprod,
        this.descrprod,
        this.compldesc
      );
    }
  }

  CodGrupoProdFilter(CodGrupoProd: number) {
    //~~ => converte string para int
    if (~~CodGrupoProd > 0) {
      this.getAll(
        1,
        10,
        this.produto,
        CodGrupoProd,
        this.descrprod,
        this.compldesc
      );
    } else {
      this.getAll(
        1,
        10,
        this.produto,
        this.codgrupoprod,
        this.descrprod,
        this.compldesc
      );
    }
  }

  DescFilter(description: string) {
    this.getAll(
      1,
      10,
      this.produto,
      this.codgrupoprod,
      description,
      this.compldesc
    );
  }

  ComplDescFilter(compldesc: string) {
    this.getAll(
      1,
      10,
      this.produto,
      this.codgrupoprod,
      this.descrprod,
      compldesc
    );
  }
}
