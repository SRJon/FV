import { Router } from '@angular/router';
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

  constructor(
    private ServiceLogin: AuthenticationService,
    private router: Router
  ) {
    let isValidToken = ServiceLogin.checkToken();
    let token = this.ServiceLogin.getToken();
    if (isValidToken && token) {
      ServiceLogin.setTokenToHeader(token);
      this.router.navigate(['/wpinicio']);
    }
  }

  ngOnInit(): void {}

  async login() {
    const { user, password } = this;
    await this.ServiceLogin.login(user, password).then(() => {
      this.router.navigate(['/wpinicio']);
    });
  }
}
