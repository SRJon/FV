import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { ClientComponent } from './Components/client/client.component';
import { RepresentanteRoutingModule } from './representante-routing.module';

@NgModule({
  declarations: [ClientComponent],
  imports: [CommonModule, RepresentanteRoutingModule],
})
export class RepresentanteModule {}
