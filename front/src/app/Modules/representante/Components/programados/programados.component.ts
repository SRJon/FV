import { Component, OnInit } from '@angular/core';
import { GlobalTitle } from 'src/app/Shared/GlobalTitle';

@Component({
  selector: 'app-programados',
  templateUrl: './programados.component.html',
  styleUrls: ['./programados.component.scss'],
})
export class ProgramadosComponent implements OnInit {
  title: string = 'Programados';
  description: string = '';

  constructor(private globalTitle: GlobalTitle<string>) {
    this.globalTitle.setValue(this.title);
  }

  ngOnInit(): void {}
}
