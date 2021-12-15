import { Component, OnInit } from '@angular/core';
import { Title } from '@angular/platform-browser';

@Component({
  selector: 'app-pedidoandamento',
  templateUrl: './pedidoandamento.component.html',
  styleUrls: ['./pedidoandamento.component.scss'],
})
export class PedidoandamentoComponent implements OnInit {
  title: string = 'Novo Pedido';
  description: string = '';

  constructor(private titleService: Title) {
    this.titleService.setTitle(this.title);
  }

  getHeigth(): number {
    let doc = document.querySelector('#middleWrapper');
    return doc ? doc.clientHeight : 0;
  }

  ngOnInit(): void {}
}
