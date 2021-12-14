import { Component, EventEmitter, Input, OnInit, Output } from '@angular/core';
import { FormGroup, FormBuilder, Validators } from '@angular/forms';
import { IPerfil } from 'src/app/Domain/Models/IPerfil';
import { IUser } from 'src/app/Domain/Models/IUser';
import { PerfilService } from 'src/app/Modules/seguranca/Services/perfil.service';
import { UserService } from 'src/app/Modules/seguranca/Services/user.service';
import { AlertsService } from 'src/app/Repository/Alerts/alerts.service';
import { EditUsuarioWords } from './edit-usuario-words';

@Component({
  selector: 'app-edit-usuario-component',
  templateUrl: './edit-usuario-component.component.html',
  styleUrls: ['./edit-usuario-component.component.scss'],
})
export class EditUsuarioComponentComponent implements OnInit {
  isLoading: boolean = true;
  @Input() usuario: IUser | undefined;
  @Output() onCloseModal = new EventEmitter<boolean>();
  words: EditUsuarioWords;
  perfis: IPerfil[] = [];
  isValid: boolean = false;
  serviceForm: FormGroup;

  constructor(
    private userService: UserService,
    private alertsService: AlertsService,
    private perfilService: PerfilService,
    private fb: FormBuilder
  ) {
    this.words = EditUsuarioWords.getInstance();
    this.serviceForm = this.fb.group({
      login: ['', Validators.required],
      senha: ['', Validators.required],
      nome: ['', Validators.required],
      email: ['', Validators.required],
      alterPassNextLogonInput: [''],
      ativo: [''],
      select: [''],
      id: [''],
    });
  }

  async onConfirm() {
    if (this.serviceForm.invalid) return;
    if (this.usuario) {
      let id = this.usuario.id || 0;
      id > 0 ? this.Doupdate() : this.DoCreate();
    }
  }

  async DoCreate() {
    try {
      if (this.usuario) {
        var response = await this.userService.createUser(this.usuario);
        if (response.success && response.data) {
          this.alertsService.showAlert(response.message);
          this.onCloseModal.emit(true);
        }
      } else {
        this.alertsService.showAlert(
          'Não foi possível criar o usuario!',
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
      if (this.usuario) {
        let result = await this.userService.updateUser(this.usuario);
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
    //this.getAllUser();
    this.getAllPerfis();
    this.words.indexTitle = this.usuario && this.usuario.id ? 1 : 0;
  }

  onClose() {
    setTimeout(() => {
      this.onCloseModal.emit(true);
      $('.modal-backdrop').remove();
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

  async getAllPerfis() {
    let response = await this.perfilService.getAllNames(0, 0);
    this.setLoading(false);
    this.perfis = response.data;
    // @ts-ignore: Unreachable code error
    $('.select2-danger').select2();
  }
}
