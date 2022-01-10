import { Component, OnInit } from '@angular/core';
import { GlobalTitle } from 'src/app/Shared/GlobalTitle';

@Component({
  selector: 'app-perfil',
  templateUrl: './perfil.component.html',
  styleUrls: ['./perfil.component.scss'],
})
export class PerfilComponent implements OnInit {
  title = 'Perfil';
  description = '';

  constructor(private globalTitle: GlobalTitle<string>) {}

  getHeigth(): number {
    const doc = document.querySelector('#middleWrapper');
    return doc ? doc.clientHeight : 0;
  }

  ngOnInit(): void {
    this.globalTitle.setValue(this.title);
  }
}
