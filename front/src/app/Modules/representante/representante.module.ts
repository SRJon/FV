import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { ClientComponent } from './Components/client/client.component';
import { RepresentanteRoutingModule } from './representante-routing.module';
import { SegurancaModule } from '../seguranca/seguranca.module';
import { ClientGridComponent } from './Components/client/Components/client-grid/client-grid.component';
import { Min_loadingComponent } from 'src/app/Components/min_loading/min_loading/min_loading.component';

@NgModule({
  declarations: [ClientComponent, ClientGridComponent, Min_loadingComponent],
  imports: [CommonModule, RepresentanteRoutingModule, SegurancaModule],
})
export class RepresentanteModule {}
