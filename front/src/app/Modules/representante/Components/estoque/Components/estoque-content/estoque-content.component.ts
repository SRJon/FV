import { Component, OnInit } from '@angular/core';
import { IAD_ESTCODPROD } from 'src/app/Domain/Models/IAD_ESTCODPROD';
import { IResponse } from 'src/app/Domain/Models/IResponse';
import { Paginate } from 'src/app/Domain/Models/Paginate';
import { StockService } from 'src/app/Modules/representante/Services/stock.service';
import { EstoqueSearch } from 'src/app/Domain/Models/estoqueSearch';

@Component({
    selector: 'app-estoque-content',
    templateUrl: './estoque-content.component.html',
    styleUrls: ['./estoque-content.component.scss'],
})
export class EstoqueContentComponent implements OnInit {
    estoques: IResponse<IAD_ESTCODPROD[]>;
    paginate: Paginate;
    isOpen = false;
    initialParam: IAD_ESTCODPROD = {} as IAD_ESTCODPROD;

    produto = -1;
    codgrupoprod = -1;
    descrprod = '';
    compldesc = '';
    estoqueSearch: EstoqueSearch;

    constructor(private stockService: StockService) {
        this.estoques = {} as IResponse<IAD_ESTCODPROD[]>;
        this.paginate = new Paginate(1, 1);

        this.initialParam = {
            produto: 0,
            codgrupoprod: 0,
            aD_CODANT: '',
            codvol: '',
            descrprod: '',
            compldesc: '',
            aD_LARGURATECIDO: 0,
            aD_GRAMATURA: 0,
            ncm: '',
            percentual: 0,
            aD_RENDIMENTOTECIDO: 0,
            aD_BRIEFING: '',
        };
        this.estoqueSearch = EstoqueSearch.getInstance();
    }
    ngOnInit(): void {
        this.getAll(1, 10);
    }

    openModal(isClose: boolean) {
        this.isOpen = !isClose;
        if (isClose) {
            this.getAll(this.paginate.currentPage, 10);
        }
    }
    getAll(page: number, limit = 10) {
        this.stockService
            .getAdEstCodProd(
                page,
                limit,
                this.estoqueSearch.produto,
                this.estoqueSearch.codgrupoprod,
                this.estoqueSearch.descrprod,
                this.estoqueSearch.compldesc
            )
            .then((response) => {
                this.estoques = response;
                this.paginate.pageSize = response.totalPages;
                this.paginate.totalItems = response.totalPages * limit;
                this.paginate.setPage();
            });
    }

    onNextSelection(page: number) {
        this.paginate.currentPage = page;
        this.getAll(page, 10);
    }
    ProdutoFilter(produto: number) {
    //~~ => converte string para int
        if (~~produto > 0) {
            this.estoqueSearch.produto = produto;
            this.getAll(1, 10);
        } else {
            this.estoqueSearch.produto = -1;
            this.getAll(1, 10);
        }
    }

    CodGrupoProdFilter(codGrupoProd: number) {
    //~~ => converte string para int
        if (~~codGrupoProd > 0) {
            this.estoqueSearch.codgrupoprod = codGrupoProd;
            this.getAll(1, 10);
        } else {
            this.estoqueSearch.codgrupoprod = -1;
            this.getAll(1, 10);
        }
    }

    DescFilter(description: string) {
        this.estoqueSearch.descrprod = description;
        this.getAll(1, 10);
    }

    ComplDescFilter(compldesc: string) {
        this.estoqueSearch.compldesc = compldesc;
        this.getAll(1, 10);
    }
}
