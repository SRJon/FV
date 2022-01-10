import { Component, OnInit } from '@angular/core';
import { IEmpresa } from 'src/app/Domain/Models/IEmpresa';
import { IResponse } from 'src/app/Domain/Models/IResponse';
import { Paginate } from 'src/app/Domain/Models/Paginate';
import { CompanyService } from 'src/app/Modules/seguranca/Services/company.service';

@Component({
    selector: 'app-empresa-content',
    templateUrl: './empresa-content.component.html',
    styleUrls: ['./empresa-content.component.scss'],
})
export class EmpresaContentComponent implements OnInit {
    empresas: IResponse<IEmpresa[]>;
    paginate: Paginate;
    isOpen = false;
    initialParam: IEmpresa = {} as IEmpresa;

    constructor(private companyService: CompanyService) {
        this.empresas = {} as IResponse<IEmpresa[]>;
        this.paginate = new Paginate(1, 1);

        this.initialParam = {
            id: 0,
            nome: '',
            vlrMinFrete: 0,
            vlrMinPedido: 0,
            codEmp: 0,
            nomefantasia: '',
            razaosocial: '',
        };
    }
    ngOnInit(): void {
        this.getAll(1);
    }

    openModal(isClose: boolean) {
        this.isOpen = !isClose;
        if (isClose) {
            this.getAll(this.paginate.currentPage);
        }
    }
    getAll(page: number, limit = 10) {
        this.companyService.getCompany(page, limit).then((response) => {
            this.empresas = response;
            this.paginate.pageSize = response.totalPages;
            this.paginate.totalItems = response.totalPages * limit;
            this.paginate.setPage();
        });
    }

    onNextSelection(page: number) {
        this.paginate.currentPage = page;
        this.getAll(page);
    }
}
