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

  constructor(
    private services: UserService,
    private alertsService: AlertsService
  ) {
    this.words = new UsuarioEditWords();
    for (let i = 0; i < 500; i++) {
      this.perfils.push({
        id: i,
        nome: 'Perfil ' + i,
      } as IPerfil);
    }
  }

  ngOnInit(): void {
    if (this.currentUser) {
      this.words.index = 0;
    } else {
      this.words.index = 1;
    }
    let select;

    let interval = setInterval(() => {
      select = $(
        '#exampleModal > div > div > div.modal-body > div > form > div > div:nth-child(7) > select'
      );

      // @ts-ignore: Unreachable code error
      select.select2();
      console.log(select);

      if (select) {
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
    if (this.currentUser) {
      let response;
      delete this.currentUser.perfil;
      delete this.currentUser.sgtsiusU_USU_COD;
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
}
