import { Component } from '@angular/core';
import { Router } from '@angular/router';
import { GlobalWatcher } from './Shared/GlocalWatcher';
import { AxiosConfig } from '../AxiosConfig';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.scss'],
})
export class AppComponent {
  title = 'fv';
  isLoading = true;
  isLogin = false;

  constructor(
    public router: Router,
    private loadingObservable: GlobalWatcher<boolean>
  ) {
    this.isLogin = location.pathname.split('/')[1] === 'login';
    router.events.pipe().subscribe(() => {
      this.isLogin = location.pathname.split('/')[1] === 'login';
    });

    this.loadingObservable.getObservable().subscribe((value) => {
      this.isLoading = value;
    });
  }

  setLoading(value: boolean) {
    this.loadingObservable.setObservable(value);
  }
  ngOnInit() {
    AxiosConfig(this.setLoading, this);
  }
}
