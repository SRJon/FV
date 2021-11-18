import { Component, EventEmitter, OnInit, Output } from '@angular/core';
import * as Entities from './../../Entities/';

@Component({
  selector: 'app-login-menu',
  templateUrl: './login-menu.component.html',
  styleUrls: ['./login-menu.component.scss'],
})
export class LoginMenuComponent implements OnInit {
  @Output() onSubmit = new EventEmitter<Entities.ILogin>();

  loginEntity: Entities.ILogin;

  constructor() {
    this.loginEntity = {
      password: '',
      user: '',
    } as Entities.ILogin;
  }

  ngOnInit(): void {}

  Login() {
    this.onSubmit.emit(this.loginEntity);
  }

  
}
