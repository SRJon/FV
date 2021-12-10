import { Component, OnInit } from '@angular/core';
import { Title } from '@angular/platform-browser';

@Component({
  selector: 'app-diretorio',
  templateUrl: './diretorio.component.html',
  styleUrls: ['./diretorio.component.scss'],
})
export class DiretorioComponent implements OnInit {
  constructor(private titleService: Title) {
    this.titleService.setTitle('Diretório');
  }

  getHeigth(): number {
    let doc = document.querySelector('#middleWrapper');
    return doc ? doc.clientHeight : 0;
  }

  ngOnInit(): void {}
}
