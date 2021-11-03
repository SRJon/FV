import { Component } from '@angular/core';
import { Router } from '@angular/router';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.scss'],
})
export class AppComponent {
  title = 'fv';

  isLogin = false;

  constructor(public router: Router) {
    router.events.pipe().subscribe(() => {
      this.isLogin = location.pathname.split('/')[1] === 'login';
    });
  }
}
