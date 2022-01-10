import { Component, EventEmitter, Input, OnInit, Output } from '@angular/core';

@Component({
  selector: 'app-dinamic-filter',
  templateUrl: './dinamic-filter.component.html',
  styleUrls: ['./dinamic-filter.component.scss'],
})
export class DinamicFilterComponent implements OnInit {
  @Input() inputs = 1;
  models: { value: string; key: string }[] = [];
  @Output() onChange = new EventEmitter<{ value: string; key: string }[]>();
  constructor() {
    this.reshape();
  }
  reshape() {
    for (let index = 0; index < this.inputs; index++) {
      this.models.push({
        key: '',
        value: '',
      });
    }
  }
  onchange() {
    this.onChange.emit(this.models);
  }

  ngOnInit(): void {}

  addInput() {
    this.inputs++;
    this.models = [];
    if (this.inputs > 3) {
      this.inputs = 3;
    }
    this.reshape();
  }
  replaceInput() {
    this.inputs--;
    this.models = [];
    this.reshape();
  }
}
