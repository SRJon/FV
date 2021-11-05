import { Routes } from '@angular/router';
import { IRoutes } from 'src/app/Repository/IRoutes';
import { PerfilComponent } from '../Components/perfil/perfil.component';

export class Route implements IRoutes {
  routes: Routes;

  constructor() {
    this.routes = [
      {
        path: '',
        component: PerfilComponent,
      },
    ];
  }
  getRoutes(): Routes {
    return this.routes;
  }
}
