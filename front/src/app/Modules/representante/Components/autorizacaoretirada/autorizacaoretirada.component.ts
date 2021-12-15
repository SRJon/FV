import { Component, OnInit } from '@angular/core';
import { Title } from '@angular/platform-browser';

@Component({
  selector: 'app-autorizacaoretirada',
  templateUrl: './autorizacaoretirada.component.html',
  styleUrls: ['./autorizacaoretirada.component.scss'],
})
export class AutorizacaoretiradaComponent implements OnInit {
  title: string = 'Autorização de Retirada';
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
