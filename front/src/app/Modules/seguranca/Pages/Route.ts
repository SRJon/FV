import { Routes } from '@angular/router';
import { IRoutes } from 'src/app/Repository/IRoutes';
import { PerfilComponent } from '../Components/perfil/perfil.component';
import { TelaComponent } from '../Components/tela/tela.component';
import { EmpresaComponent } from '../Components/empresa/empresa.component';
import { UsuarioComponent } from '../Components/usuario/usuario.component';
import { DiretorioComponent } from '../Components/diretorio/diretorio.component';
import { ParametroComponent } from '../Components/parametro/parametro.component';

export class Route implements IRoutes {
  routes: Routes;

  constructor() {
    this.routes = [
      {
        path: 'perfil',
        component: PerfilComponent,
      },
      {
        path: 'tela',
        component: TelaComponent,
      },
      {
        path: 'empresa',
        component: EmpresaComponent,
      },
      {
        path: 'usuario',
        component: UsuarioComponent,
      },
      {
        path: 'diretorio',
        component: DiretorioComponent,
      },
      {
        path: 'parametro',
        component: ParametroComponent,
      },
    ];
  }
  getRoutes(): Routes {
    return this.routes;
  }
}
