import { Component, EventEmitter, Input, OnInit, Output } from '@angular/core';
import { FormGroup, FormBuilder, Validators } from '@angular/forms';
import { IPerfil } from 'src/app/Domain/Models/IPerfil';
import { PerfilService } from 'src/app/Modules/seguranca/Services/perfil.service';
import { AlertsService } from 'src/app/Repository/Alerts/alerts.service';
import { EditPerfilWords } from './edit-perfil-words';

@Component({
  selector: 'app-edit-perfil-component',
  templateUrl: './edit-perfil-component.component.html',
  styleUrls: ['./edit-perfil-component.component.scss'],
})
export class EditPerfilComponentComponent implements OnInit {
  isLoading = true;
  @Input() perfil: IPerfil | undefined;
  @Output() onCloseModal = new EventEmitter<boolean>();
  words: EditPerfilWords;
  isValid = false;
  serviceForm: FormGroup;

  constructor(
    private perfilService: PerfilService,
    private alertsService: AlertsService,
    private fb: FormBuilder
  ) {
    this.words = EditPerfilWords.getInstance();
    this.serviceForm = this.fb.group({
      nome: ['', Validators.required],
    });
  }

  async onConfirm() {
    if (this.serviceForm.invalid) return;
    if (this.perfil) {
      const id = this.perfil.id || 0;
      id > 0 ? this.DoUpdate() : this.DoCreate();
    }
  }
  async DoCreate() {
    try {
      if (this.perfil) {
        const response = await this.perfilService.createPerfil(this.perfil);
        if (response.success && response.data) {
          this.alertsService.showAlert(response.message);
          this.onCloseModal.emit(true);
        }
      } else {
        this.alertsService.showAlert(
          'Não foi possível criar o perfil!',
          'error'
        );
      }
    } catch (error: any) {
      this.alertsService.showAlert(error.response.data.message, 'error');
    } finally {
      this.onClose();
    }
  }
  async DoUpdate() {
    try {
      if (this.perfil) {
        const result = await this.perfilService.updatePerfil(this.perfil);
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
    this.getAllNamesPerfil();
    this.words.indexTitle = this.perfil && this.perfil.id ? 1 : 0;
  }

  onClose() {
    setTimeout(() => {
      this.onCloseModal.emit(true);
      $('.modal-backdrop').remove();
    }, 500);
  }
  async getAllNamesPerfil() {
    const result = await this.perfilService.getAllNamesPerfil(0, 0);
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
