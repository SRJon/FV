import { Component, OnInit } from '@angular/core';
import { Title } from '@angular/platform-browser';
@Component({
  selector: 'app-parametro',
  templateUrl: './parametro.component.html',
  styleUrls: ['./parametro.component.scss'],
})
export class ParametroComponent implements OnInit {
  title: string = 'Parâmetro';
  description: string = '';
  constructor(private titleService: Title) {
    this.titleService.setTitle('Parâmetro');
  }

  getHeigth(): number {
    let doc = document.querySelector('#middleWrapper');
    return doc ? doc.clientHeight : 0;
  }

  ngOnInit(): void {}
}
