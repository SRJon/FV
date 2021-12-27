import { Component, Input, OnInit } from '@angular/core';
import { IAvgfrpvgetall } from 'src/app/Domain/Models/IAvgfrpvgetall';

@Component({
  selector: 'app-Geral',
  templateUrl: './Geral.component.html',
  styleUrls: ['./Geral.component.scss'],
})
export class GeralComponent implements OnInit {
  @Input() data!: IAvgfrpvgetall;

  constructor() {}

  ngOnInit() {
    console.log(this.data, 'sssssssssssssssssss');
  }
}
