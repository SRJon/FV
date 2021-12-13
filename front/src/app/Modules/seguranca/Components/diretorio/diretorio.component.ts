import { Component, OnInit } from '@angular/core';
import { Title } from '@angular/platform-browser';
import { GlobalTitle } from 'src/app/Shared/GlobalTitle';

@Component({
  selector: 'app-diretorio',
  templateUrl: './diretorio.component.html',
  styleUrls: ['./diretorio.component.scss'],
})
export class DiretorioComponent implements OnInit {
  title: string = 'Diretório';
  description: string = '';
  _title: string = '';
  constructor(
    private titleService: Title,
    private globalTitle: GlobalTitle<string>
  ) {
    this.titleService.setTitle(this.title);
    this.globalTitle.getObservable().subscribe((value) => {
      this._title = value;
    });
  }

  getHeigth(): number {
    let doc = document.querySelector('#middleWrapper');
    return doc ? doc.clientHeight : 0;
  }

  ngOnInit(): void {
    this.globalTitle.setValue(this.title);
  }
}
