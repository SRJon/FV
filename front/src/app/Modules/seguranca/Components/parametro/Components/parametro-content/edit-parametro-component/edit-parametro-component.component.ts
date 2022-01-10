import { Component, EventEmitter, Input, OnInit, Output } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { IParametro } from 'src/app/Domain/Models/IParametro';
import { ParameterService } from 'src/app/Modules/seguranca/Services/parameter.service';
import { AlertsService } from 'src/app/Repository/Alerts/alerts.service';
import { EditParametroWords } from './edit-parametro-words';

@Component({
  selector: 'app-edit-parametro-component',
  templateUrl: './edit-parametro-component.component.html',
  styleUrls: ['./edit-parametro-component.component.scss'],
})
export class EditParametroComponentComponent implements OnInit {
  isLoading = true;
  @Input() parametro: IParametro | undefined;
  @Output() onCloseModal = new EventEmitter<boolean>();
  words: EditParametroWords;
  isValid = false;
  serviceForm: FormGroup;

  constructor(
    private parameterService: ParameterService,
    private alertsService: AlertsService,
    private fb: FormBuilder
  ) {
    this.words = EditParametroWords.getInstance();
    this.serviceForm = this.fb.group({
      nome: ['', Validators.required],
      valor: ['', Validators.required],
      descricao: ['', Validators.required],
    });
  }

  async onConfirm() {
    if (this.serviceForm.invalid) return;
    if (this.parametro) {
      const id = this.parametro.id || 0;
      id > 0 ? this.Doupdate() : this.DoCreate();
    }
  }
  async DoCreate() {
    try {
      if (this.parametro) {
        const response = await this.parameterService.createParameter(
          this.parametro
        );
        if (response.success && response.data) {
          this.alertsService.showAlert(response.message);
          this.onCloseModal.emit(true);
        }
      } else {
        this.alertsService.showAlert(
          'Não foi possível criar a parametro!',
          'error'
        );
      }
    } catch (error: any) {
      this.alertsService.showAlert(error.response.data.message, 'error');
    } finally {
      this.onClose();
    }
  }
  async Doupdate() {
    try {
      if (this.parametro) {
        const result = await this.parameterService.updateParameter(
          this.parametro
        );
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
    this.getAllParameter();
    this.words.indexTitle = this.parametro && this.parametro.id ? 1 : 0;
  }

  onClose() {
    setTimeout(() => {
      this.onCloseModal.emit(true);
      $('.modal-backdrop').remove();
    }, 500);
  }
  async getAllParameter() {
    const result = await this.parameterService.getParameter(0, 0);
    this.setLoading(false);
    // @ts-ignore: Unreachable code error
    $('.select2-danger').select2();
  }
  setLoading(value: boolean) {
    this.isLoading = value;
    this.changeStateLoadComponent();
  }
  changeStateLoadComponent() {
    const component = document.getElementById('overloadModal');
    if (component) {
      component.style.display = this.isLoading ? 'block' : 'none';
    }
  }
}
