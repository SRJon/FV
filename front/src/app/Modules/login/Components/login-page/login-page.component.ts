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
  isLoading: boolean;

  constructor(
    private ServiceLogin: AuthenticationService,
    private router: Router
  ) {
    this.isLoading = false;
    let isValidToken = ServiceLogin.checkToken();
    let token = this.ServiceLogin.getToken();
    if (isValidToken && token) {
      ServiceLogin.setTokenToHeader(token);
      this.router.navigate(['/wpinicio']);
    }
  }

  ngOnInit(): void {}

  async login() {
    this.isLoading = true;
    const { user, password } = this;
    try {
      await this.ServiceLogin.login(user, password).then(() => {
        location.reload();
        this.router.navigate(['/wpinicio']);
      });
    } catch (error) {
    } finally {
      setTimeout(() => {
        this.isLoading = false;
      }, 2000);
    }
  }
}
