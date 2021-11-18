import {
  Component,
  EventEmitter,
  Input,
  OnChanges,
  OnInit,
  Output,
  SimpleChanges,
} from '@angular/core';
import { ITela } from 'src/app/Domain/Models/ITela';
import { ScreensService } from 'src/app/Modules/seguranca/Services/screens.service';
import { AlertsService } from '../../../../../../../Repository/Alerts/alerts.service';

@Component({
  selector: 'app-edit-tela-component',
  templateUrl: './edit-tela-component.component.html',
  styleUrls: ['./edit-tela-component.component.scss'],
})
export class EditTelaComponentComponent implements OnInit, OnChanges {
  isLoading: boolean = true;
  @Input() tela: ITela | undefined;
  @Output() onCloseModal = new EventEmitter<boolean>();
  subTelas: ITela[] = [];

  constructor(
    private screensService: ScreensService,
    private alertsService: AlertsService
  ) {}

  ngOnChanges(changes: SimpleChanges): void {
    console.log(changes);
  }
  async onConfirm() {
    this.Doupdate();
  }
  async Doupdate() {
    try {
      if (this.tela) {
        let result = await this.screensService.updateScreen(this.tela);
        if (result.success && result.data) {
          this.alertsService.showAlert(result.message);
        }
      }
    } catch (error: any) {
      this.alertsService.showAlert(error.responseresult.message, 'error');
    } finally {
      this.onClose();
      $('.modal-backdrop').remove();
    }
  }
  onchange() {
    console.log(this.tela);
  }

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
    this.subTelas = result.data;

    // @ts-ignore: Unreachable code error
    $('.select2-danger').select2();
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
