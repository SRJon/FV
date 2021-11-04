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
    {
      path: 'wpinicio',
      loadChildren: () =>
        import('../Modules/home/home.module').then((m) => m.HomeModule),
    },
  ];

  getRoutes(): Routes {
    var instance = new Route();
    return instance.routes;
  }
}
