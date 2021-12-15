import { Component, OnInit } from '@angular/core';
import { Title } from '@angular/platform-browser';
import { GlobalTitle } from 'src/app/Shared/GlobalTitle';

@Component({
  selector: 'app-perfil',
  templateUrl: './perfil.component.html',
  styleUrls: ['./perfil.component.scss'],
})
export class PerfilComponent implements OnInit {
  title: string = 'Perfil';
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

  ngOnInit(): void {
    this.globalTitle.setValue(this.title);
  }
}
