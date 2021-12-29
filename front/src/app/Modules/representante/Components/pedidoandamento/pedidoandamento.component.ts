import { Component, OnInit } from '@angular/core';
import { GlobalTitle } from 'src/app/Shared/GlobalTitle';

@Component({
  selector: 'app-pedidoandamento',
  templateUrl: './pedidoandamento.component.html',
  styleUrls: ['./pedidoandamento.component.scss'],
})
export class PedidoandamentoComponent implements OnInit {
  title: string = 'Novo Pedido';
  description: string = '';

  constructor(private globalTitle: GlobalTitle<string>) {
    this.globalTitle.setValue(this.title);
  }

  ngOnInit(): void {}
}
