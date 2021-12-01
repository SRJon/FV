import { Routes } from '@angular/router';
import { IRoutes } from 'src/app/Repository/IRoutes';
import { RepresentanteComponent } from '../representante.component';

export class Route implements IRoutes {
  routes: Routes;

  constructor() {
    this.routes = [
      {
        path: '',
        component: RepresentanteComponent,
      },
    ];
  }
  getRoutes(): Routes {
    throw new Error('Method not implemented.');
  }
}
