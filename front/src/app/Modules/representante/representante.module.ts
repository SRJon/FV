import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { ClientComponent } from './Components/client/client.component';
import { RepresentanteRoutingModule } from './representante-routing.module';
import { SegurancaModule } from '../seguranca/seguranca.module';
import { ClientGridComponent } from './Components/client/Components/client-grid/client-grid.component';
import { Min_loadingComponent } from 'src/app/Components/min_loading/min_loading/min_loading.component';
import { GeralComponent } from './Components/client/Components/client_details/Components/Geral/Geral.component';
import { Client_detailsComponent } from './Components/client/Components/client_details/client_details.component';
// a
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
// m
import { ClientPerfilComponent } from './Components/client/Components/client_details/Components/client-perfil/client-perfil.component';
import { GridClientPerfilComponent } from './Components/client/Components/client_details/Components/client-perfil/Components/grid-client-perfil/grid-client-perfil.component';
import { SolicitacaoDevolucaoComponent } from './Components/client/Components/client_details/Components/client-perfil/Components/solicitacao-devolucao/solicitacao-devolucao.component';
import { DinamicFilterComponent } from './Components/client/Components/client_details/Components/client-perfil/Components/dinamic-filter/dinamic-filter.component';
import { GridSolicitacaoDevolucaoComponent } from './Components/client/Components/client_details/Components/client-perfil/Components/grid-solicitacao-devolucao/grid-solicitacao-devolucao.component';
import { GridNotaFiscalComponent } from './Components/client/Components/client_details/Components/client-perfil/Components/grid-nota-fiscal/grid-nota-fiscal.component';
import { NotaFiscalComponent } from './Components/client/Components/client_details/Components/client-perfil/Components/nota-fiscal/nota-fiscal.component';
import { FinanceiroGridComponent } from './Components/client/Components/client_details/Components/client-perfil/Components/financeiro-grid/financeiro-grid.component';
import { FinanceiroComponent } from './Components/client/Components/client_details/Components/client-perfil/Components/financeiro/financeiro.component';
import { FormsModule } from '@angular/forms';
import { EstoqueGridComponent } from './Components/estoque/Components/estoque-grid/estoque-grid.component';
import { EstoqueContentComponent } from './Components/estoque/Components/estoque-content/estoque-content.component';
import { DetailEstoqueComponentComponent } from './Components/estoque/Components/estoque-content/detail-estoque-component/detail-estoque-component.component';
import { ReportEstoqueComponentComponent } from './Components/estoque/Components/estoque-content/report-estoque-component/report-estoque-component.component';

@NgModule({
  imports: [
    CommonModule,
    RepresentanteRoutingModule,
    SegurancaModule,
    FormsModule,
  ],
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

    ClientPerfilComponent,
    GridClientPerfilComponent,
    SolicitacaoDevolucaoComponent,
    DinamicFilterComponent,
    GridSolicitacaoDevolucaoComponent,
    GridNotaFiscalComponent,
    NotaFiscalComponent,
    FinanceiroGridComponent,
    FinanceiroComponent,
    EstoqueGridComponent,
    EstoqueContentComponent,
    DetailEstoqueComponentComponent,
    ReportEstoqueComponentComponent,
  ],
  bootstrap: [ClientComponent],
  exports: [ClientComponent, GeralComponent],
})
export class RepresentanteModule {}
