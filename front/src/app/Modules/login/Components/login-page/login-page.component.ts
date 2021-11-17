import { AlertsService } from './../../../../Repository/Alerts/alerts.service';
import * as loginEntity from './../../Entities/ILogin';
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

  stateEnum = {
    isLogin: 'l',
    isNewPassword: 'p',
    isCheckEmal: 'e',
  };
  state: string = this.stateEnum.isNewPassword;

  constructor(
    private ServiceLogin: AuthenticationService,
    private router: Router,
    private alertsService: AlertsService
  ) {
    this.isLoading = false;
    let isValidToken = ServiceLogin.checkToken();
    let token = this.ServiceLogin.getToken();
    if (isValidToken && token) {
      ServiceLogin.setTokenToHeader(token);
      this.router.navigate(['/wpinicio']);
    }
  }

  teste(n: number) {
    switch (n) {
      case 1:
        this.state = this.stateEnum.isCheckEmal;
        break;
      case 2:
        this.state = this.stateEnum.isLogin;
        break;
      case 3:
        this.state = this.stateEnum.isNewPassword;
        break;

      default:
        break;
    }
  }

  ngOnInit(): void {}

  async login(toLogin: loginEntity.ILogin) {
    this.isLoading = true;
    const { user, password } = this;
    try {
      await this.ServiceLogin.login(user, password).then(() => {
        location.reload();

        this.router.navigate(['/wpinicio']);
      });
    } catch (error: any) {
      // console.log(error.response);alertsService
      let status = error.response.status || 500;

      if (status === 500) {
        this.alertsService.showAlert('Ocorreu um error tente novamente!', 'error');
      } else {
        this.alertsService.showAlert(error.response.data, 'warning');
      }
    } finally {
      setTimeout(() => {
        this.isLoading = false;
      }, 2000);
    }
  }
}
