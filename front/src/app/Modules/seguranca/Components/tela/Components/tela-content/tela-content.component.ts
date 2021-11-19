import { Component, OnInit } from '@angular/core';
import { IResponse } from 'src/app/Domain/Models/IResponse';
import { ITela } from 'src/app/Domain/Models/ITela';
import { Paginate } from 'src/app/Domain/Models/Paginate';
import { ScreensService } from 'src/app/Modules/seguranca/Services/screens.service';

@Component({
  selector: 'app-tela-content',
  templateUrl: './tela-content.component.html',
  styleUrls: ['./tela-content.component.scss'],
})
export class TelaContentComponent implements OnInit {
  telas: IResponse<ITela[]>;
  paginate: Paginate;
  isOpen: boolean = false;
  initialParam: ITela = {} as ITela;

  constructor(private screensService: ScreensService) {
    this.telas = {} as IResponse<ITela[]>;
    this.paginate = new Paginate(1, 1);

    this.initialParam = {
      id: 0,
      nome: '',
      addUrl: ' ',
      iconClass: ' ',
      imagemSd: ' ',
      modulo: ' ',
      ordem: 0,
      nivel: false,
      relateds: [],
      sd: false,
      target: '',
      tela: null,
      telaId: undefined,
      url: '',
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
  getAll(page: number, limit: number = 7) {
    this.screensService.getScreens(page, limit).then((response) => {
      // this.telas = telas;
      // this.cdRef.detectChanges();
      this.telas = response;
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
