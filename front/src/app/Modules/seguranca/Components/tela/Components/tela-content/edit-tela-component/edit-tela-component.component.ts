import { Component, EventEmitter, Input, OnInit, Output } from '@angular/core';
import { ITela } from 'src/app/Domain/Models/ITela';
import { ScreensService } from 'src/app/Modules/seguranca/Services/screens.service';

@Component({
  selector: 'app-edit-tela-component',
  templateUrl: './edit-tela-component.component.html',
  styleUrls: ['./edit-tela-component.component.scss'],
})
export class EditTelaComponentComponent implements OnInit {
  isLoading: boolean = true;
  @Input() tela: ITela | undefined;
  @Output() onCloseModal = new EventEmitter<boolean>();
  subTelas: ITela[] = [];

  constructor(private screensService: ScreensService) {}

  ngOnInit(): void {
    this.getAllScreens();
  }

  onClose() {
    setTimeout(() => {
      this.onCloseModal.emit(true);
    }, 500);
  }
  async getAllScreens() {
    let result = await this.screensService.getScreens(0, 0);
    this.setLoading(false);
    this.subTelas = result.data; // @ts-ignore: Unreachable code error

    $('.select2-danger').select2();
    console.log(this.tela);
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
