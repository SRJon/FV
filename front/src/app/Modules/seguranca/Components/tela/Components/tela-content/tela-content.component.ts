import { ChangeDetectorRef, Component, OnInit } from '@angular/core';
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

  constructor(private screensService: ScreensService) {
    this.telas = {} as IResponse<ITela[]>;
    this.paginate = new Paginate(1, 1);
  }
  getAll(page: number) {
    this.screensService.getScreens(page, 10).then((response) => {
      // this.telas = telas;
      // this.cdRef.detectChanges();
      this.telas = response;
      this.paginate.pageSize = response.totalPages;
      this.paginate.totalItems = response.totalPages * 10;
      this.paginate.setPage();
    });
  }
  ngOnInit(): void {
    this.getAll(1);
  }

  onNextSelection(page: number) {
    this.paginate.currentPage = page;
    this.getAll(page);
  }
}
