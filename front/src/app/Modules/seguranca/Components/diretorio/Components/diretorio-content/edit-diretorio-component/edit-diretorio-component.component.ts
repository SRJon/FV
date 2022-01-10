import { Component, EventEmitter, Input, OnInit, Output } from '@angular/core';
import { FormGroup, FormBuilder, Validators } from '@angular/forms';
import { IDiretorio } from 'src/app/Domain/Models/IDiretorio';
import { DirectoryService } from 'src/app/Modules/seguranca/Services/directory.service';
import { AlertsService } from 'src/app/Repository/Alerts/alerts.service';
import { EditDiretorioWords } from './edit-diretorio-words';

@Component({
  selector: 'app-edit-diretorio-component',
  templateUrl: './edit-diretorio-component.component.html',
  styleUrls: ['./edit-diretorio-component.component.scss'],
})
export class EditDiretorioComponentComponent implements OnInit {
  isLoading = true;
  @Input() diretorio: IDiretorio | undefined;
  @Output() onCloseModal = new EventEmitter<boolean>();
  words: EditDiretorioWords;
  isValid = false;
  serviceForm: FormGroup;

  constructor(
    private directoryService: DirectoryService,
    private alertsService: AlertsService,
    private fb: FormBuilder
  ) {
    this.words = EditDiretorioWords.getInstance();
    this.serviceForm = this.fb.group({
      tipo: ['', Validators.required],
      link: ['', Validators.required],
      virtual: ['', Validators.required],
    });
  }

  async onConfirm() {
    if (this.serviceForm.invalid) return;
    if (this.diretorio) {
      const id = this.diretorio.id || 0;
      id > 0 ? this.Doupdate() : this.DoCreate();
    }
  }
  async DoCreate() {
    try {
      if (this.diretorio) {
        const response = await this.directoryService.createDirectory(
          this.diretorio
        );
        if (response.success && response.data) {
          this.alertsService.showAlert(response.message);
          this.onCloseModal.emit(true);
        }
      } else {
        this.alertsService.showAlert(
          'Não foi possível criar o diretorio!',
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
      if (this.diretorio) {
        const result = await this.directoryService.updateDirectory(
          this.diretorio
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
    this.getAllDirectory();
    this.words.indexTitle = this.diretorio && this.diretorio.id ? 1 : 0;
  }

  onClose() {
    setTimeout(() => {
      this.onCloseModal.emit(true);
      $('.modal-backdrop').remove();
    }, 500);
  }
  async getAllDirectory() {
    const result = await this.directoryService.getDirectory(0, 0);
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
