import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { ClientComponent } from './Components/client/client.component';
import { RepresentanteRoutingModule } from './representante-routing.module';
import { SegurancaModule } from '../seguranca/seguranca.module';
import { ClientGridComponent } from './Components/client/Components/client-grid/client-grid.component';
import { Min_loadingComponent } from 'src/app/Components/min_loading/min_loading/min_loading.component';
import { GeralComponent } from './Components/client/Components/client_details/Components/Geral/Geral.component';
import { Client_detailsComponent } from './Components/client/Components/client_details/client_details.component';
import { PedidoandamentoComponent } from './Components/pedidoandamento/pedidoandamento.component';
import { PedidosComponent } from './Components/pedidos/pedidos.component';
import { ClientesComponent } from './Components/clientes/clientes.component';
import { EstoqueComponent } from './Components/estoque/estoque.component';
import { AutorizacaoretiradaComponent } from './Components/autorizacaoretirada/autorizacaoretirada.component';
import { SacComponent } from './Components/sac/sac.component';
import { ComissaoComponent } from './Components/comissao/comissao.component';
import { IniciorepresentanteComponent } from './Components/iniciorepresentante/iniciorepresentante.component';
import { AnexoComponent } from './Components/anexo/anexo.component';
import { TabprecoComponent } from './Components/tabpreco/tabpreco.component';
import { BookComponent } from './Components/book/book.component';
import { ProgramadosComponent } from './Components/programados/programados.component';

@NgModule({
  imports: [CommonModule, RepresentanteRoutingModule, SegurancaModule],
  declarations: [
    GeralComponent,
    ClientComponent,
    ClientGridComponent,
    Min_loadingComponent,
    Client_detailsComponent,
    PedidoandamentoComponent,
    PedidosComponent,
    ClientesComponent,
    EstoqueComponent,
    AutorizacaoretiradaComponent,
    SacComponent,
    ComissaoComponent,
    IniciorepresentanteComponent,
    AnexoComponent,
    TabprecoComponent,
    BookComponent,
    ProgramadosComponent,
  ],
  bootstrap: [ClientComponent],
  exports: [ClientComponent, GeralComponent],
})
export class RepresentanteModule {}
