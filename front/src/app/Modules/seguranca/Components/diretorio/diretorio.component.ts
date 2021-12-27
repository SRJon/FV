import { Component, OnInit } from '@angular/core';
import { GlobalTitle } from 'src/app/Shared/GlobalTitle';

@Component({
  selector: 'app-diretorio',
  templateUrl: './diretorio.component.html',
  styleUrls: ['./diretorio.component.scss'],
})
export class DiretorioComponent implements OnInit {
  title: string = 'Diretório';
  description: string = '';

  constructor(private globalTitle: GlobalTitle<string>) {
    this.globalTitle.setValue(this.title);
  }

  getHeigth(): number {
    let doc = document.querySelector('#middleWrapper');
    return doc ? doc.clientHeight : 0;
  }

  ngOnInit(): void {}
}
