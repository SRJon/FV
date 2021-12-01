import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { RepresentanteComponent } from './Components/representante/representante.component';
import { LoginRoutingModule } from '../login/login-routing.module';

@NgModule({
  declarations: [RepresentanteComponent],
  imports: [CommonModule, LoginRoutingModule],
})
export class RepresentanteModule {}
