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

  constructor(private services: UserService) {
    this.words = new UsuarioEditWords();
  }

  ngOnInit(): void {
    if (this.currentUser) {
      this.words.index = 0;
    } else {
      this.words.index = 1;
    }
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
  onSave() {
    if (this.currentUser) {
      delete this.currentUser.perfil;
      delete this.currentUser.sgtsiusU_USU_COD;
      delete this.currentUser.senhaFV;
      delete this.currentUser.senha;
      this.services.update(this.currentUser);
    }
  }
}
