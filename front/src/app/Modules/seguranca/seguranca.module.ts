import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { PerfilComponent } from './Components/perfil/perfil.component';
import { SegurancaRoutingModule } from './seguranca-routing.module';
import { TelaComponent } from './Components/tela/tela.component';
import { EmpresaComponent } from './Components/empresa/empresa.component';
import { UsuarioComponent } from './Components/usuario/usuario.component';
import { DiretorioComponent } from './Components/diretorio/diretorio.component';
import { ParametroComponent } from './Components/parametro/parametro.component';

@NgModule({
  imports: [CommonModule, SegurancaRoutingModule],
  declarations: [PerfilComponent, TelaComponent, EmpresaComponent, UsuarioComponent, DiretorioComponent, ParametroComponent],
  bootstrap: [PerfilComponent],
})
export class SegurancaModule {}
