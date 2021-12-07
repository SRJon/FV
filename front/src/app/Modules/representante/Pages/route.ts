import { Routes } from '@angular/router';
import { IRoutes } from 'src/app/Repository/IRoutes';
import { ClientComponent } from '../Components/client/client.component';
import { Client_detailsComponent } from '../Components/client/Components/client_details/client_details.component';

export class Route implements IRoutes {
  routes: Routes;

  constructor() {
    this.routes = [
      {
        path: 'wpclientes/details/:id',
        component: Client_detailsComponent,
      },
      {
        path: 'wpclientes',
        component: ClientComponent,
      },
    ];
  }
  getRoutes(): Routes {
    return this.routes;
  }
}
