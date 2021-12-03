import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-empresa',
  templateUrl: './empresa.component.html',
  styleUrls: ['./empresa.component.scss'],
})
export class EmpresaComponent implements OnInit {
  title: string = 'Empresa';
  description: string = '';

  constructor() {}
  getHeigth(): number {
    let doc = document.querySelector('#middleWrapper');
    return doc ? doc.clientHeight : 0;
  }
  ngOnInit(): void {}
}
