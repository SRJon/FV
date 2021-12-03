import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { ClientComponent } from './Components/client/client.component';
import { RepresentanteRoutingModule } from './representante-routing.module';
import { SegurancaModule } from '../seguranca/seguranca.module';
import { ClientGridComponent } from './Components/client/Components/client-grid/client-grid.component';

@NgModule({
  declarations: [ClientComponent, ClientGridComponent],
  imports: [CommonModule, RepresentanteRoutingModule, SegurancaModule],
})
export class RepresentanteModule {}
