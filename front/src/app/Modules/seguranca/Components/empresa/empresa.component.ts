import { Component, OnInit } from '@angular/core';
import { Title } from '@angular/platform-browser';
import { GlobalTitle } from 'src/app/Shared/GlobalTitle';

@Component({
  selector: 'app-empresa',
  templateUrl: './empresa.component.html',
  styleUrls: ['./empresa.component.scss'],
})
export class EmpresaComponent implements OnInit {
  title: string = 'Empresa';
  description: string = '';
  _title: string = '';

  constructor(
    private titleService: Title,
    private globalTitle: GlobalTitle<string>
  ) {
    this.titleService.setTitle(this.title);
    this.globalTitle.getObs((value: string) => {
      this._title = value;
    });
    this.globalTitle.setValue(this.title);
  }

  getHeigth(): number {
    let doc = document.querySelector('#middleWrapper');
    return doc ? doc.clientHeight : 0;
  }

  ngOnInit(): void {}
}
