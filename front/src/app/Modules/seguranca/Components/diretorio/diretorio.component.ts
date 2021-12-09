import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-diretorio',
  templateUrl: './diretorio.component.html',
  styleUrls: ['./diretorio.component.scss'],
})
export class DiretorioComponent implements OnInit {
  title: string = 'Diretório';
  description: string = '';

  constructor() {}

  getHeigth(): number {
    let doc = document.querySelector('#middleWrapper');
    return doc ? doc.clientHeight : 0;
  }

  ngOnInit(): void {}
}
