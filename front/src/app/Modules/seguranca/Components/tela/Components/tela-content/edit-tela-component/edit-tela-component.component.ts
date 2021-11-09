import { Component, EventEmitter, Input, OnInit, Output } from '@angular/core';
import { ITela } from 'src/app/Domain/Models/ITela';

@Component({
  selector: 'app-edit-tela-component',
  templateUrl: './edit-tela-component.component.html',
  styleUrls: ['./edit-tela-component.component.scss'],
})
export class EditTelaComponentComponent implements OnInit {
  isLoading: boolean = true;
  @Input() tela: ITela | undefined;
  @Output() onCloseModal = new EventEmitter<boolean>();
  constructor() {}

  ngOnInit(): void {
    setTimeout(() => {
      this.setLoading(false);
      console.log(this.tela);
    }, 3000);
  }

  onClose() {
    setTimeout(() => {
      this.onCloseModal.emit(true);
    }, 500);
  }
  setLoading(value: boolean) {
    this.isLoading = value;
    this.changeStateLoadComponent();
  }
  changeStateLoadComponent() {
    let component = document.getElementById('overloadModal');
    if (component) {
      component.style.display = this.isLoading ? 'block' : 'none';
    }
  }
}
