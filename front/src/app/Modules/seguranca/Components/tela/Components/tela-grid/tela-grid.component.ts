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

  clickOnPagination(page: number): void {
    console.log(page);
    this.nextSelection.emit(page);
    // paginate.currentPage = page
  }

  objToTh(obj: any): HTMLTableCellElement[] {
    let ths: HTMLTableCellElement[] = [];
    for (let key in obj) {
      let th = document.createElement('th');
      if (!this.titleList.includes(key)) {
        this.titleList.push(key);
      }
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

  clickRow(obj: ITela, str: string): void {
    console.log(obj, str);
  }

  checkIfIsObject(obj: any): boolean {
    return obj[0] === '[';
  }
  constructor() {
    console.log(this.listGrid, 'teste');
    this.paginate = new Paginate(2000, 50);

    // eslint-disable-next-line no-console
    /* eslint-disable no-console */
  }

  ngOnInit(): void {
    console.log(this.listGrid, 'teste');
  }
}
