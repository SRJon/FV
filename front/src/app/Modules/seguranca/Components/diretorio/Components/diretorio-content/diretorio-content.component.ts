import { Component, OnInit } from '@angular/core';
import { IDiretorio } from 'src/app/Domain/Models/IDiretorio';
import { IResponse } from 'src/app/Domain/Models/IResponse';
import { Paginate } from 'src/app/Domain/Models/Paginate';
import { DirectoryService } from 'src/app/Modules/seguranca/Services/directory.service';

@Component({
  selector: 'app-diretorio-content',
  templateUrl: './diretorio-content.component.html',
  styleUrls: ['./diretorio-content.component.scss'],
})
export class DiretorioContentComponent implements OnInit {
  diretorios: IResponse<IDiretorio[]>;
  paginate: Paginate;
  isOpen: boolean = false;
  initialParam: IDiretorio = {} as IDiretorio;

  constructor(private directoryService: DirectoryService) {
    this.diretorios = {} as IResponse<IDiretorio[]>;
    this.paginate = new Paginate(1, 1);

    this.initialParam = {
      id: 0,
      tipo: 0,
      link: '',
      virtual: '',
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
    this.directoryService.getDirectory(page, limit).then((response) => {
      this.diretorios = response;
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
