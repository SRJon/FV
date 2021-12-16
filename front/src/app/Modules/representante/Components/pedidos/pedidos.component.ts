import { Component, OnInit } from '@angular/core';
import { Title } from '@angular/platform-browser';
import { GlobalTitle } from 'src/app/Shared/GlobalTitle';

@Component({
  selector: 'app-pedidos',
  templateUrl: './pedidos.component.html',
  styleUrls: ['./pedidos.component.scss'],
})
export class PedidosComponent implements OnInit {
  title: string = 'Pedidos';
  description: string = '';
  _title: string = '';

  constructor(
    private titleService: Title,
    private globalTitle: GlobalTitle<string>
  ) {
    this.titleService.setTitle(this.title);
    this.globalTitle.getObs((value: string) => {
      this._title = value;
    });
    this.globalTitle.setValue(this.title);
  }

  ngOnInit(): void {}
}
