import { Component, OnInit } from '@angular/core';
import { GlobalTitle } from 'src/app/Shared/GlobalTitle';
@Component({
  selector: 'app-tela',
  templateUrl: './tela.component.html',
  styleUrls: ['./tela.component.scss'],
})
export class TelaComponent implements OnInit {
  title = 'Tela';
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
