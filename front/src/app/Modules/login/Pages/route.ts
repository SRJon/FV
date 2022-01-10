import { LoginPageComponent } from './../Components/login-page/login-page.component';
import { Routes } from '@angular/router';
import { IRoutes } from './../../../Repository/IRoutes';

export class Route implements IRoutes {
    routes: Routes;

    constructor() {
        this.routes = [
            {
                path: '',
                component: LoginPageComponent,
            },
        ];
    }
    getRoutes(): Routes {
        throw new Error('Method not implemented.');
    }
}
