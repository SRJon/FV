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
    {
      path: 'seguranca',
      loadChildren: () =>
        import('../Modules/seguranca/seguranca.module').then(
          (m) => m.SegurancaModule
        ),
    },
    {
      path: 'representante',
      loadChildren: () =>
        import('../Modules/representante/representante.module').then(
          (m) => m.RepresentanteModule
        ),
    },
  ];

  getRoutes(): Routes {
    var instance = new Route();
    return instance.routes;
  }
}
