import { Component, OnInit } from '@angular/core';
import { LoginPageComponent } from '../login-page/login-page.component';

@Component({
    selector: 'app-refactor-password',
    templateUrl: './refactor-password.component.html',
    styleUrls: ['./refactor-password.component.scss'],
})
export class RefactorPasswordComponent implements OnInit {
    constructor(private backLogin: LoginPageComponent) {}

    back() {
        this.backLogin.teste(2);
    }

    ngOnInit(): void {}
}
