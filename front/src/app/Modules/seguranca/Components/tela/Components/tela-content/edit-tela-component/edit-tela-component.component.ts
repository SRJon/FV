import { Component, EventEmitter, Input, OnInit, Output } from '@angular/core';
import {
  FormBuilder,
  FormControl,
  FormGroup,
  Validators,
} from '@angular/forms';
import { ITela } from 'src/app/Domain/Models/ITela';
import { ScreensService } from 'src/app/Modules/seguranca/Services/screens.service';
import { AlertsService } from '../../../../../../../Repository/Alerts/alerts.service';
import { EditTelaWords } from './edit-tela-words';

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
  words: EditTelaWords;
  isValid: boolean = false;
  serviceForm: FormGroup;

  constructor(
    private screensService: ScreensService,
    private alertsService: AlertsService,
    private fb: FormBuilder
  ) {
    this.words = EditTelaWords.getInstance();
    this.serviceForm = this.fb.group({
      nome: ['', Validators.required],
      url: ['', Validators.required],
    });
  }

  async onConfirm() {
    if (this.serviceForm.invalid) return;
    if (this.tela) {
      let id = this.tela.id || 0;
      id > 0 ? this.Doupdate() : this.DoCreate();
    }
  }
  async DoCreate() {
    try {
      if (this.tela) {
        var response = await this.screensService.createScreen(this.tela);
        if (response.success && response.data) {
          this.alertsService.showAlert(response.message);
          this.onCloseModal.emit(true);
        }
      } else {
        this.alertsService.showAlert('Não foi possível criar a tela!', 'error');
      }
    } catch (error: any) {
      this.alertsService.showAlert(error.response.data.message, 'error');
    } finally {
      this.onClose();
    }
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
    }
  }

  ngOnInit(): void {
    this.getAllScreens();
    this.words.indexTitle = this.tela && this.tela.id ? 1 : 0;
  }

  onClose() {
    setTimeout(() => {
      this.onCloseModal.emit(true);
      $('.modal-backdrop').remove();
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
