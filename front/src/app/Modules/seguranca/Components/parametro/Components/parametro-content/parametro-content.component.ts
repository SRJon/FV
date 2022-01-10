import { Component, OnInit } from '@angular/core';
import { IParametro } from 'src/app/Domain/Models/IParametro';
import { IResponse } from 'src/app/Domain/Models/IResponse';
import { Paginate } from 'src/app/Domain/Models/Paginate';
import { ParameterService } from 'src/app/Modules/seguranca/Services/parameter.service';

@Component({
  selector: 'app-parametro-content',
  templateUrl: './parametro-content.component.html',
  styleUrls: ['./parametro-content.component.scss'],
})
export class ParametroContentComponent implements OnInit {
  parametros: IResponse<IParametro[]>;
  paginate: Paginate;
  isOpen = false;
  initialParam: IParametro = {} as IParametro;

  constructor(private parameterService: ParameterService) {
    this.parametros = {} as IResponse<IParametro[]>;
    this.paginate = new Paginate(1, 1);

    this.initialParam = {
      id: 0,
      nome: '',
      valor: '',
      descricao: '',
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
    this.parameterService.getParameter(page, limit).then((response) => {
      this.parametros = response;
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
