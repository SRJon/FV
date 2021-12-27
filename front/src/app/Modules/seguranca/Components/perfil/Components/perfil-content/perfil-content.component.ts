import { Component, OnInit } from '@angular/core';
import { IPerfil } from 'src/app/Domain/Models/IPerfil';
import { IResponse } from 'src/app/Domain/Models/IResponse';
import { Paginate } from 'src/app/Domain/Models/Paginate';
import { PerfilService } from 'src/app/Modules/seguranca/Services/perfil.service';

@Component({
  selector: 'app-perfil-content',
  templateUrl: './perfil-content.component.html',
  styleUrls: ['./perfil-content.component.scss'],
})
export class PerfilContentComponent implements OnInit {
  perfils: IResponse<IPerfil[]>;
  paginate: Paginate;
  isOpen: boolean = false;
  initialParam: IPerfil = {} as IPerfil;

  constructor(private perfilService: PerfilService) {
    this.perfils = {} as IResponse<IPerfil[]>;
    this.paginate = new Paginate(1, 1);

    this.initialParam = {
      id: 0,
      nome: '',
      peR_COD: 0,
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
  getAll(page: number, limit: number = 10) {
    this.perfilService.getAllNamesPerfil(page, limit).then((response) => {
      this.perfils = response;
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
