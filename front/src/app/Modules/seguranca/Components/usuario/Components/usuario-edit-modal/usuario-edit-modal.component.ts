import {
  Component,
  OnInit,
  Input,
  Output,
  EventEmitter,
  OnChanges,
} from '@angular/core';
import { UserService } from 'src/app/Modules/seguranca/Services/user.service';
import { IUser } from '../../../../../../Domain/Models/IUser';
import { UsuarioEditWords } from './usuario-edit-words';
import { AlertsService } from '../../../../../../Repository/Alerts/alerts.service';
import { IPerfil } from 'src/app/Domain/Models/IPerfil';
import { PerfilService } from 'src/app/Modules/seguranca/Services/perfil.service';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';

@Component({
  selector: 'app-usuario-edit-modal',
  templateUrl: './usuario-edit-modal.component.html',
  styleUrls: ['./usuario-edit-modal.component.scss'],
})
export class UsuarioEditModalComponent implements OnInit, OnChanges {
  @Input() isOpen: boolean = false;
  @Output() modalState = new EventEmitter<boolean>();
  @Input() currentUser: IUser | undefined;
  @Output() onDisabled = new EventEmitter<boolean>();
  words: UsuarioEditWords;
  perfils: IPerfil[] = [];
  select?: JQuery<HTMLElement>;
  serviceForm: FormGroup;

  constructor(
    private services: UserService,
    private alertsService: AlertsService,
    private perfilService: PerfilService,
    private fb: FormBuilder
  ) {
    this.words = new UsuarioEditWords();
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

  ngOnInit(): void {
    this.getAllPerfils();
    if (this.currentUser) {
      this.words.index = 0;
    } else {
      this.words.index = 1;
    }

    let interval = setInterval(() => {
      this.select = $(
        '#exampleModal > div > div > div.modal-body > div > form > div > div:nth-child(7) > select'
      );

      // @ts-ignore: Unreachable code error
      this.select.select2();
      console.log(this.select);

      if (this.select) {
        clearInterval(interval);
      }
    }, 100);
  }

  ngOnChanges(): void {
    if (!this.isOpen) {
      var div: HTMLDivElement | null = document.querySelector('#exampleModal');
      setTimeout(() => {
        div!.style.display = 'none';
        this.onDispose();
      }, 700);
    } else {
      var div: HTMLDivElement | null = document.querySelector('#exampleModal');
      div!.style.display = 'block';
    }
  }

  onDispose() {
    this.onDisabled.emit(true);
  }

  onModalChange() {
    this.modalState.emit(!this.isOpen);
  }
  async onSave() {
    if (this.serviceForm.invalid) return;
    if (this.currentUser) {
      let response;
      // this.currentUser.perfilId = this.currentUser.perfil
      //   ? this.currentUser.perfil.id
      //   : this.currentUser.perfilId;
      if (this.select) {
        // this.currentUser.perfilId = Number(this.select.val());
        let val = this.select.val();
        let options = document.querySelectorAll('option');
        options.forEach((option) => {
          if (option.value === val) {
            // this.currentUser?.perfilId = option.text;
            let c = option.attributes.item(1);
            if (c) {
              this.currentUser!.perfilId = Number(c.value);
            }
          }
        });
        console.log(val, options);
      }
      delete this.currentUser.perfil;
      delete this.currentUser.sgtsiusU_USU_COD;
      this.currentUser.vendedorUCod = 1;
      // delete this.currentUser.senhaFV;
      // delete this.currentUser.senha;
      let res;
      if (this.currentUser.id > 0) {
        response = await this.services.update(this.currentUser);
      } else {
        response = await this.services.create(this.currentUser);
      }

      if (response.message) {
        let words = response.message.split(' ');
        for (let i = 0; i < words.length; i++) {
          if (words[i] === 'NULL') {
            words[i] = 'Vazio';
          }
        }
        res = this.arrayToString(words);
      } else {
        res = response.message;
      }

      this.alertsService.showAlert(res, response.data ? 'success' : 'error');

      this.onDispose();
    }
  }
  arrayToString(array: string[]): string {
    let result = '';
    for (let i = 0; i < array.length; i++) {
      result += ' ' + array[i];
    }
    return result;
  }

  async getAllPerfils() {
    let response = await this.perfilService.getAllNames(0, 0);
    this.perfils = response.data;
  }
}
