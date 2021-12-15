import { PedidosComponent } from './../Components/pedidos/pedidos.component';
import { TabprecoComponent } from './../Components/tabpreco/tabpreco.component';
import { SacComponent } from './../Components/sac/sac.component';
import { ProgramadosComponent } from './../Components/programados/programados.component';
import { IniciorepresentanteComponent } from './../Components/iniciorepresentante/iniciorepresentante.component';
import { EstoqueComponent } from './../Components/estoque/estoque.component';
import { ComissaoComponent } from './../Components/comissao/comissao.component';
import { BookComponent } from './../Components/book/book.component';
import { AutorizacaoretiradaComponent } from './../Components/autorizacaoretirada/autorizacaoretirada.component';
import { AnexoComponent } from './../Components/anexo/anexo.component';
import { Routes } from '@angular/router';
import { IRoutes } from 'src/app/Repository/IRoutes';
import { ClientComponent } from '../Components/client/client.component';
import { Client_detailsComponent } from '../Components/client/Components/client_details/client_details.component';
import { PedidoandamentoComponent } from '../Components/pedidoandamento/pedidoandamento.component';

export class Route implements IRoutes {
  routes: Routes;

  constructor() {
    this.routes = [
      {
        path: 'anexo',
        component: AnexoComponent,
      },
      {
        path: 'autorizacaoretirada',
        component: AutorizacaoretiradaComponent,
      },
      {
        path: 'book',
        component: BookComponent,
      },
      {
        path: 'clientes/details/:id',
        component: Client_detailsComponent,
      },
      {
        path: 'clientes',
        component: ClientComponent,
      },
      {
        path: 'comissao',
        component: ComissaoComponent,
      },
      {
        path: 'estoque',
        component: EstoqueComponent,
      },
      {
        path: 'iniciorepresentante',
        component: IniciorepresentanteComponent,
      },
      {
        path: 'iniciorepresentante',
        component: IniciorepresentanteComponent,
      },
      {
        path: 'pedidoandamento',
        component: PedidoandamentoComponent,
      },
      {
        path: 'pedidos',
        component: PedidosComponent,
      },
      {
        path: 'programados',
        component: ProgramadosComponent,
      },
      {
        path: 'sac',
        component: SacComponent,
      },
      {
        path: 'tabpreco',
        component: TabprecoComponent,
      },
    ];
  }
  getRoutes(): Routes {
    return this.routes;
  }
}
