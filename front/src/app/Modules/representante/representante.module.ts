import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { ClientComponent } from './Components/client/client.component';
import { RepresentanteRoutingModule } from './representante-routing.module';
import { SegurancaModule } from '../seguranca/seguranca.module';
import { ClientGridComponent } from './Components/client/Components/client-grid/client-grid.component';
import { Min_loadingComponent } from 'src/app/Components/min_loading/min_loading/min_loading.component';
import { GeralComponent } from './Components/client/Components/client_details/Components/Geral/Geral.component';
import { Client_detailsComponent } from './Components/client/Components/client_details/client_details.component';
import { ClientPerfilComponent } from './Components/client/Components/client_details/Components/client-perfil/client-perfil.component';
import { GridClientPerfilComponent } from './Components/client/Components/client_details/Components/client-perfil/Components/grid-client-perfil/grid-client-perfil.component';
import { SolicitacaoDevolucaoComponent } from './Components/client/Components/client_details/Components/client-perfil/Components/solicitacao-devolucao/solicitacao-devolucao.component';
import { DinamicFilterComponent } from './Components/client/Components/client_details/Components/client-perfil/Components/dinamic-filter/dinamic-filter.component';
import { GridSolicitacaoDevolucaoComponent } from './Components/client/Components/client_details/Components/client-perfil/Components/grid-solicitacao-devolucao/grid-solicitacao-devolucao.component';
import { GridNotaFiscalComponent } from './Components/client/Components/client_details/Components/client-perfil/Components/grid-nota-fiscal/grid-nota-fiscal.component';
import { NotaFiscalComponent } from './Components/client/Components/client_details/Components/client-perfil/Components/nota-fiscal/nota-fiscal.component';
import { FinanceiroGridComponent } from './Components/client/Components/client_details/Components/client-perfil/Components/financeiro-grid/financeiro-grid.component';
import { FinanceiroComponent } from './Components/client/Components/client_details/Components/client-perfil/Components/financeiro/financeiro.component';

@NgModule({
  imports: [CommonModule, RepresentanteRoutingModule, SegurancaModule],
  declarations: [
    GeralComponent,
    ClientComponent,
    ClientGridComponent,
    Min_loadingComponent,
    Client_detailsComponent,
    ClientPerfilComponent,
    GridClientPerfilComponent,
    SolicitacaoDevolucaoComponent,
    DinamicFilterComponent,
    GridSolicitacaoDevolucaoComponent,
    GridNotaFiscalComponent,
    NotaFiscalComponent,
    FinanceiroGridComponent,
    FinanceiroComponent,
  ],
  bootstrap: [ClientComponent],
  exports: [ClientComponent, GeralComponent],
})
export class RepresentanteModule {}
