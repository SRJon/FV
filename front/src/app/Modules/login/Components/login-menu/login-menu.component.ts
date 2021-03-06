import {
  FormBuilder,
  Validators,
  FormGroup,
  FormControl,
} from '@angular/forms';
import { AlertsService } from 'src/app/Repository/Alerts/alerts.service';
import { ScreensService } from 'src/app/Modules/seguranca/Services/screens.service';
import { Component, EventEmitter, OnInit, Output } from '@angular/core';
import * as Entities from './../../Entities/';
import { LoginPageComponent } from '../login-page/login-page.component';

@Component({
  selector: 'app-login-menu',
  templateUrl: './login-menu.component.html',
  styleUrls: ['./login-menu.component.scss'],
})
export class LoginMenuComponent implements OnInit {
  @Output() onSubmit = new EventEmitter<Entities.ILogin>();

  loginEntity: Entities.ILogin;
  serviceForm: FormGroup;

  constructor(
    private FormBuilder: FormBuilder,
    private loginew: LoginPageComponent
  ) {
    this.serviceForm = this.FormBuilder.group({
      user: ['', [Validators.required, Validators.minLength(2)]],
      password: ['', [Validators.required, Validators.minLength(4)]],
    });

    this.loginEntity = {
      password: '',
      user: '',
    } as Entities.ILogin;
  }

  ngOnInit(): void {}

  Redefine() {
    this.loginew.teste(1);
  }

  Login() {
    if (this.serviceForm.valid) {
      this.onSubmit.emit(this.loginEntity);
      return;
    } else {
      return;
    }
  }
  getEntries(obj: any) {
    return Object.entries(obj).map((e) => e[0]);
  }
}
