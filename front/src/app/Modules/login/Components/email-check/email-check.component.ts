import { Component, OnInit } from '@angular/core';
import { LoginPageComponent } from '../login-page/login-page.component';

@Component({
  selector: 'app-email-check',
  templateUrl: './email-check.component.html',
  styleUrls: ['./email-check.component.scss']
})
export class EmailCheckComponent implements OnInit {

  constructor(
    private backLogin: LoginPageComponent
  ) { }

  back(){
    this.backLogin.teste(2);
  }

  ngOnInit(): void {
  }

}
