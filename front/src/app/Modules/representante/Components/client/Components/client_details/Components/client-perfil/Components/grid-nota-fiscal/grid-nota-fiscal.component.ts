import { Component, Input, OnInit } from '@angular/core';
import { INotaFiscal } from 'src/app/Domain/Models/INotaFiscal';

@Component({
    selector: 'app-grid-nota-fiscal',
    templateUrl: './grid-nota-fiscal.component.html',
    styleUrls: ['./grid-nota-fiscal.component.scss'],
})
export class GridNotaFiscalComponent implements OnInit {
  @Input() listGrid: INotaFiscal[];
  constructor() {
      this.listGrid = [];
  }

  ngOnInit(): void {}
}
