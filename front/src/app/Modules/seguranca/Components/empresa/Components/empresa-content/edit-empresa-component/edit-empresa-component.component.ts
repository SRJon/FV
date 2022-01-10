import { Component, EventEmitter, Input, OnInit, Output } from '@angular/core';
import { FormGroup, FormBuilder, Validators } from '@angular/forms';
import { IEmpresa } from 'src/app/Domain/Models/IEmpresa';
import { CompanyService } from 'src/app/Modules/seguranca/Services/company.service';
import { AlertsService } from 'src/app/Repository/Alerts/alerts.service';
import { EditEmpresaWords } from './edit-empresa-words';

@Component({
    selector: 'app-edit-empresa-component',
    templateUrl: './edit-empresa-component.component.html',
    styleUrls: ['./edit-empresa-component.component.scss'],
})
export class EditEmpresaComponentComponent implements OnInit {
    isLoading = true;
  @Input() empresa: IEmpresa | undefined;
  @Output() onCloseModal = new EventEmitter<boolean>();
  subEmpresas: IEmpresa[] = [];
  words: EditEmpresaWords;
  isValid = false;
  serviceForm: FormGroup;

  constructor(
    private companyService: CompanyService,
    private alertsService: AlertsService,
    private fb: FormBuilder
  ) {
      this.words = EditEmpresaWords.getInstance();
      this.serviceForm = this.fb.group({
          nome: ['', Validators.required],
          codEmp: ['', Validators.required],
      });
  }

  async onConfirm() {
      if (this.serviceForm.invalid) return;
      if (this.empresa) {
          const id = this.empresa.id || 0;
          id > 0 ? this.Doupdate() : this.DoCreate();
      }
  }
  async DoCreate() {
      try {
          if (this.empresa) {
              const response = await this.companyService.createCompany(this.empresa);
              if (response.success && response.data) {
                  this.alertsService.showAlert(response.message);
                  this.onCloseModal.emit(true);
              }
          } else {
              this.alertsService.showAlert(
                  'Não foi possível criar a empresa!',
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
          if (this.empresa) {
              const result = await this.companyService.updateCompany(this.empresa);
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
      this.getAllCompany();
      this.words.indexTitle = this.empresa && this.empresa.id ? 1 : 0;
  }

  onClose() {
      setTimeout(() => {
          this.onCloseModal.emit(true);
          $('.modal-backdrop').remove();
      }, 500);
  }
  async getAllCompany() {
      const result = await this.companyService.getCompany(0, 0);
      this.setLoading(false);
      this.subEmpresas = result.data;

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
