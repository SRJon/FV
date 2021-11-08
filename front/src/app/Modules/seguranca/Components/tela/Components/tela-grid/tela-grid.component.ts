import { Component, OnInit } from '@angular/core';
import { ITela } from '../../../../../../Domain/Models/ITela';

@Component({
  selector: 'app-tela-grid',
  templateUrl: './tela-grid.component.html',
  styleUrls: ['./tela-grid.component.scss'],
})
export class TelaGridComponent implements OnInit {
  listGrid: ITela[] = [];
  titleList: string[] = ['Rendering engine  '];

  objToTh(obj: any) {
    let ths: HTMLTableCellElement[] = [];
    for (let key in obj) {
      let th = document.createElement('th');
      th.innerHTML = key;
      ths.push(th);
    }
    console.log(ths);
  }
  constructor() {}

  ngOnInit(): void {}
}
