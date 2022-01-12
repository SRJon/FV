import { Routes } from '@angular/router';
import { IRoutes } from 'src/app/Repository/IRoutes';
import { QRCComponent } from '../Components/qrc/qrc.component';

export class Route implements IRoutes {
  readonly routes: Routes = [
    {
      path: '',
      component: QRCComponent,
    },

  ];

  getRoutes(): Routes {
    const instance = new Route();
    return instance.routes;
  }
}
