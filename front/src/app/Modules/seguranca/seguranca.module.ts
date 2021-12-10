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
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { EditTelaComponentComponent } from './Components/tela/Components/tela-content/edit-tela-component/edit-tela-component.component';
import { UsuarioEditModalComponent } from './Components/usuario/Components/usuario-edit-modal/usuario-edit-modal.component';
import { EmpresaGridComponent } from './Components/empresa/Components/empresa-grid/empresa-grid.component';
import { EditEmpresaComponentComponent } from './Components/empresa/Components/empresa-content/edit-empresa-component/edit-empresa-component.component';
import { EmpresaContentComponent } from './Components/empresa/Components/empresa-content/empresa-content.component';
import { ParametroGridComponent } from './Components/parametro/Components/parametro-grid/parametro-grid.component';
import { ParametroContentComponent } from './Components/parametro/Components/parametro-content/parametro-content.component';
import { EditParametroComponentComponent } from './Components/parametro/Components/parametro-content/edit-parametro-component/edit-parametro-component.component';
import { DiretorioContentComponent } from './Components/diretorio/Components/diretorio-content/diretorio-content.component';
import { DiretorioGridComponent } from './Components/diretorio/Components/diretorio-grid/diretorio-grid.component';
import { EditDiretorioComponentComponent } from './Components/diretorio/Components/diretorio-content/edit-diretorio-component/edit-diretorio-component.component';
import { PerfilGridComponent } from './Components/perfil/Components/perfil-grid/perfil-grid.component';

@NgModule({
  imports: [
    CommonModule,
    SegurancaRoutingModule,
    FormsModule,
    ReactiveFormsModule,
  ],
  declarations: [
    PerfilComponent,
    TelaComponent,
    EmpresaComponent,
    UsuarioComponent,
    DiretorioComponent,
    ParametroComponent,
    TitleComponent,
    TelaContentComponent,
    TelaGridComponent,
    EditTelaComponentComponent,
    UsuarioEditModalComponent,
    EmpresaGridComponent,
    EditEmpresaComponentComponent,
    EmpresaContentComponent,
    ParametroGridComponent,
    ParametroContentComponent,
    EditParametroComponentComponent,
    DiretorioContentComponent,
    DiretorioGridComponent,
    EditDiretorioComponentComponent,
    PerfilGridComponent,
  ],
  bootstrap: [PerfilComponent],
  exports: [TitleComponent],
})
export class SegurancaModule {}
