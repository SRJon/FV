import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { ClientComponent } from './Components/client/client.component';
import { RepresentanteRoutingModule } from './representante-routing.module';
import { SegurancaModule } from '../seguranca/seguranca.module';
import { ClientGridComponent } from './Components/client/Components/client-grid/client-grid.component';
import { Min_loadingComponent } from 'src/app/Components/min_loading/min_loading/min_loading.component';
import { GeralComponent } from './Components/client/Components/client_details/Components/Geral/Geral.component';
import { Client_detailsComponent } from './Components/client/Components/client_details/client_details.component';

@NgModule({
  imports: [CommonModule, RepresentanteRoutingModule, SegurancaModule],
  declarations: [
    GeralComponent,
    ClientComponent,
    ClientGridComponent,
    Min_loadingComponent,
    Client_detailsComponent,
  ],
  bootstrap: [ClientComponent],
  exports: [ClientComponent, GeralComponent],
})
export class RepresentanteModule {}
