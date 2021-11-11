import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { LoginRoutingModule } from './login-routing.module';
import { LoginPageComponent } from './Components/login-page/login-page.component';
import { FormsModule } from '@angular/forms';
import { LoginMenuComponent } from './Components/login-menu/login-menu.component';
import { RefactorPasswordComponent } from './Components/refactor-password/refactor-password.component';


@NgModule({
  declarations: [
    LoginPageComponent,
    LoginMenuComponent,
    RefactorPasswordComponent
  ],
  imports: [
    CommonModule,
    LoginRoutingModule,
    FormsModule
  ]
})
export class LoginModule { }
