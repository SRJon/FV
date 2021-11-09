import { Component, EventEmitter, Input, OnInit, Output } from '@angular/core';
import { ITela } from '../../../../../../Domain/Models/ITela';
import { Paginate } from '../../../../../../Domain/Models/Paginate';

@Component({
  selector: 'app-tela-grid',
  templateUrl: './tela-grid.component.html',
  styleUrls: ['./tela-grid.component.scss'],
})
export class TelaGridComponent implements OnInit {
  @Input() listGrid: any[] = [];
  titleList: string[] = [];
  @Input() paginate: Paginate;
  @Input() totalItems: number = 0;
  @Output() nextSelection = new EventEmitter<number>();
  selectedRecord: ITela | undefined;

  clickOnPagination(page: number): void {
    this.nextSelection.emit(page);
    // paginate.currentPage = page
  }

  objToTh(obj: any): HTMLTableCellElement[] {
    let ths: HTMLTableCellElement[] = [];
    for (let key in obj) {
      let th = document.createElement('th');

      if (key != 'actions') {
        try {
          let value = obj[key]();
          if (typeof value === 'object') {
            th.innerHTML = JSON.stringify(value);
          } else {
            th.innerHTML = value;
          }
        } catch (error) {
          let value = obj[key];

          th.innerHTML = value;
        } finally {
          ths.push(th);
        }
      }
    }

    return ths;
  }
  stateModal(isClose: boolean): void {
    if (isClose) {
      this.selectedRecord = undefined;
    }
  }
  openModal(obj: ITela): void {
    this.selectedRecord = obj;
  }

  checkIfIsObject(obj: any): boolean {
    return obj[0] === '[';
  }
  constructor() {
    this.paginate = new Paginate(2000, 50);

    // eslint-disable-next-line no-console
    /* eslint-disable no-console */
  }

  ngOnInit(): void {}

  nextPage(): void {
    if (this.paginate.currentPage !== this.paginate.pageSize) {
      this.paginate.currentPage++;
      this.clickOnPagination(this.paginate.currentPage);
    }
  }
  previousPage(): void {
    if (this.paginate.currentPage > 1) {
      this.paginate.currentPage--;
      this.clickOnPagination(this.paginate.currentPage);
    }
  }
  ngOnChanges(): void {
    let firstScren;
    try {
      if ((firstScren = this.listGrid[0])) {
        for (let k in firstScren) {
          if (!this.titleList.includes(k)) {
            this.titleList.push(k);
          }
        }
      }
    } catch (error) {}
  }
}
