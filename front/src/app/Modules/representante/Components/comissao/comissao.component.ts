import { Component, OnInit } from '@angular/core';
import { GlobalTitle } from 'src/app/Shared/GlobalTitle';

@Component({
  selector: 'app-comissao',
  templateUrl: './comissao.component.html',
  styleUrls: ['./comissao.component.scss'],
})
export class ComissaoComponent implements OnInit {
  title: string = 'Comissão';
  description: string = '';
  _title: string = '';

  constructor(private globalTitle: GlobalTitle<string>) {
    this.globalTitle.setValue(this.title);
  }

  ngOnInit(): void {}
}
