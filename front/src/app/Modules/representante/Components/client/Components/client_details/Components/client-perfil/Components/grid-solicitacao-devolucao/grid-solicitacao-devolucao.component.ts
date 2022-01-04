import { Component, Input, OnInit } from '@angular/core';
import { ISolicitacaoDevolucao } from 'src/app/Domain/Models/ISolicitacaoDevolucao';

@Component({
  selector: 'app-grid-solicitacao-devolucao',
  templateUrl: './grid-solicitacao-devolucao.component.html',
  styleUrls: ['./grid-solicitacao-devolucao.component.scss'],
})
export class GridSolicitacaoDevolucaoComponent implements OnInit {
  @Input() listGrid: ISolicitacaoDevolucao[];

  constructor() {
    this.listGrid = [];
  }

  ngOnInit(): void {}
  convertDate(date: Date) {
    return new Date(date).toLocaleDateString();
  }
  converType(type: string) {
    let response = '';

    switch (type) {
      case 'P':
      case 'p':
        response = 'Parcial';
        break;
      case 'T':
      case 't':
        response = 'Total';
        break;
      default:
        response = 'Parcial';
        break;
    }

    return response;
  }
}
