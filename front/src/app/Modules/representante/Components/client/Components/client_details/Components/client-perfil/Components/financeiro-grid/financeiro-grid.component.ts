import { Component, Input, OnInit } from '@angular/core';
import { INotaFinanceiro } from 'src/app/Domain/Models/NotaFinanceiro';

@Component({
  selector: 'app-financeiro-grid',
  templateUrl: './financeiro-grid.component.html',
  styleUrls: ['./financeiro-grid.component.scss'],
})
export class FinanceiroGridComponent implements OnInit {
  @Input() listGrid: INotaFinanceiro[] = [];

  constructor() {}

  ngOnInit(): void {}

  computedDate(data: Date) {
    let d = new Date(data);
    return d.toLocaleDateString('pt-BR');
  }
}
