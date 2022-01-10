import { IAD_ESTCODPROD } from 'src/app/Domain/Models/IAD_ESTCODPROD';
import { Component, EventEmitter, Input, OnInit, Output } from '@angular/core';

@Component({
  selector: 'app-detail-estoque-component',
  templateUrl: './detail-estoque-component.component.html',
  styleUrls: ['./detail-estoque-component.component.scss'],
})
export class DetailEstoqueComponentComponent implements OnInit {
  @Input() estoque: IAD_ESTCODPROD | undefined;
  @Output() onCloseModal = new EventEmitter<boolean>();

  constructor() {}

  ngOnInit(): void {}
}
