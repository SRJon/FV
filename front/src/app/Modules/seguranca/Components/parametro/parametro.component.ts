import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-parametro',
  templateUrl: './parametro.component.html',
  styleUrls: ['./parametro.component.scss'],
})
export class ParametroComponent implements OnInit {
  title: string = 'Parâmetro';
  description: string = '';

  constructor() {}

  getHeigth(): number {
    let doc = document.querySelector('#middleWrapper');
    return doc ? doc.clientHeight : 0;
  }

  ngOnInit(): void {}
}
