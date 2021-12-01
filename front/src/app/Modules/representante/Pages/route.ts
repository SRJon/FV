import { Routes } from '@angular/router';
import { IRoutes } from 'src/app/Repository/IRoutes';
import { ClientComponent } from '../Components/client/client.component';

export class Route implements IRoutes {
  routes: Routes;

  constructor() {
    this.routes = [
      {
        path: 'wpclientes',
        component: ClientComponent,
      },
    ];
  }
  getRoutes(): Routes {
    throw new Error('Method not implemented.');
  }
}
