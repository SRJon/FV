import { Component, OnInit } from '@angular/core';
import { Title } from '@angular/platform-browser';

@Component({
  selector: 'app-programados',
  templateUrl: './programados.component.html',
  styleUrls: ['./programados.component.scss'],
})
export class ProgramadosComponent implements OnInit {
  title: string = 'Programados';
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
