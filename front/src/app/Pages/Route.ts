import { Routes } from '@angular/router';
import { IRoutes } from '../Repository/IRoutes';

export class Route implements IRoutes {

  readonly routes: Routes = [
    {
      path: '',
      redirectTo: 'login',
      pathMatch: 'full',
    },
    {
      path: 'login',
      loadChildren: () =>
        import('../Modules/login/login.module').then((m) => m.LoginModule),
    },
  ];

  getRoutes(): Routes {
    var instance = new Route();
    return instance.routes;
  }
}
