import { AsideMenu } from './Models/AsideMenu';
import { Component } from '@angular/core';
import { Router } from '@angular/router';
import { GlobalWatcher } from './Shared/GlocalWatcher';
import { AxiosConfig } from '../AxiosConfig';
import { GlobalMenuService } from './Shared/global-menu.service';
import { AuthenticationService } from './Modules/login/Services/Authentication.service';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.scss'],
})
export class AppComponent {
  title = 'fv';
  isLoading = true;
  isLogin = false;
  menuAsideModal = new AsideMenu();

  constructor(
    public router: Router,
    private loadingObservable: GlobalWatcher<boolean>,
    private menuAsideObs: GlobalMenuService<AsideMenu>,
    private authenticator: AuthenticationService
  ) {
    this.isLogin = location.pathname.split('/')[1] === 'login';
    router.events.pipe().subscribe(() => {
      this.isLogin = location.pathname.split('/')[1] === 'login';
    });

    this.loadingObservable.getObservable().subscribe((value) => {
      this.isLoading = value;
    });
    this.menuAsideObs.getObservable().subscribe((value) => {
      this.menuAsideModal.setValue(value.open);
    });
  }

  Logout() {
    this.authenticator.removeToken();
  }

  setLoading(value: boolean) {
    this.loadingObservable.setObservable(value);
  }
  setMenuState(value: boolean) {
    this.menuAsideModal.setValue(value);

    this.menuAsideObs.setObservable(this.menuAsideModal);
  }
  ngOnInit() {
    AxiosConfig(this.setLoading, this);
  }

  getHeight() {
    let dom = document.getElementById('middleWrapper');
    if (this.isLogin) return -1;
    if (dom) {
      return dom.clientHeight;
    }
    return 0;
  }
}
