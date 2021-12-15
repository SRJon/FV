import { Component, OnInit } from '@angular/core';
import { Title } from '@angular/platform-browser';

@Component({
  selector: 'app-iniciorepresentante',
  templateUrl: './iniciorepresentante.component.html',
  styleUrls: ['./iniciorepresentante.component.scss'],
})
export class IniciorepresentanteComponent implements OnInit {
  title: string = 'Início';
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
