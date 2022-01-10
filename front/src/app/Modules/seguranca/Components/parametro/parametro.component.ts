import { Component, OnInit } from '@angular/core';
import { GlobalTitle } from 'src/app/Shared/GlobalTitle';
@Component({
  selector: 'app-parametro',
  templateUrl: './parametro.component.html',
  styleUrls: ['./parametro.component.scss'],
})
export class ParametroComponent implements OnInit {
  title = 'Parâmetro';
  description = '';

  constructor(private globalTitle: GlobalTitle<string>) {
    this.globalTitle.setValue(this.title);
  }

  getHeigth(): number {
    const doc = document.querySelector('#middleWrapper');
    return doc ? doc.clientHeight : 0;
  }

  ngOnInit(): void {}
}
