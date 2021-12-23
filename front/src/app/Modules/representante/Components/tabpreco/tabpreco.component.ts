import { Component, OnInit } from '@angular/core';
import { GlobalTitle } from 'src/app/Shared/GlobalTitle';

@Component({
  selector: 'app-tabpreco',
  templateUrl: './tabpreco.component.html',
  styleUrls: ['./tabpreco.component.scss'],
})
export class TabprecoComponent implements OnInit {
  title: string = 'Tabela de Preço';
  description: string = '';

  constructor(private globalTitle: GlobalTitle<string>) {
    this.globalTitle.setValue(this.title);
  }

  ngOnInit(): void {}
}
