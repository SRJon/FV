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

  cpfComputed() {
    return this.data.cgc_cpf.replace(
      /(^[0-9]{2})([0-9]{3})([0-9]{3})([0-9]{4})([0-9]{2})/gm,
      `$1.$2.$3/$4-$5`
    );
  }

  priceComputed() {
    return new Intl.NumberFormat('pt-BR', {
      style: 'currency',
      currency: 'BRL',
    }).format(this.data.limcred);
  }
}
