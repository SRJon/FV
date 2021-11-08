import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { PerfilComponent } from './Components/perfil/perfil.component';
import { SegurancaRoutingModule } from './seguranca-routing.module';
import { TelaComponent } from './Components/tela/tela.component';
import { EmpresaComponent } from './Components/empresa/empresa.component';
import { UsuarioComponent } from './Components/usuario/usuario.component';
import { DiretorioComponent } from './Components/diretorio/diretorio.component';
import { ParametroComponent } from './Components/parametro/parametro.component';
import { TitleComponent } from './Components/tela/Components/title/title.component';
import { TelaContentComponent } from './Components/tela/Components/tela-content/tela-content.component';
import { TelaGridComponent } from './Components/tela/Components/tela-grid/tela-grid.component';

@NgModule({
  imports: [CommonModule, SegurancaRoutingModule],
  declarations: [PerfilComponent, TelaComponent, EmpresaComponent, UsuarioComponent, DiretorioComponent, ParametroComponent, TitleComponent, TelaContentComponent, TelaGridComponent],
  bootstrap: [PerfilComponent],
})
export class SegurancaModule {}
