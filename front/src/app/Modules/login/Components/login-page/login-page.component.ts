import { Component, OnInit } from '@angular/core';
import { AuthenticationService } from './../../Services/Authentication.service';

@Component({
  selector: 'app-login-page',
  templateUrl: './login-page.component.html',
  styleUrls: ['./login-page.component.scss'],
})
export class LoginPageComponent implements OnInit {
  user: string = '';
  password: string = '';

  constructor(private ServiceLogin: AuthenticationService) {
    console.log(ServiceLogin);
  }

  ngOnInit(): void {}

  async login() {
    const { user, password } = this;
    await this.ServiceLogin.login(user, password);
    this.ServiceLogin.teste();
  }
}
