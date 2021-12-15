import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { SegurancaRoutingModule } from './seguranca-routing.module';

import { FormsModule, ReactiveFormsModule } from '@angular/forms';

import { EditTelaComponentComponent } from './Components/tela/Components/tela-content/edit-tela-component/edit-tela-component.component';
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
import { UsuarioGridComponent } from './Components/usuario/Components/usuario-grid/usuario-grid.component';
import { UsuarioContentComponent } from './Components/usuario/Components/usuario-content/usuario-content.component';
import { EditUsuarioComponentComponent } from './Components/usuario/Components/usuario-content/edit-usuario-component/edit-usuario-component.component';


import * as perfil from './Components/perfil';
import * as tela from './Components/tela';
import * as diretorio from './Components/diretorio';
import * as parametro from './Components/parametro';
import * as emp from './Components/empresa';
import * as user from './Components/usuario';

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
    UsuarioGridComponent,
    UsuarioContentComponent,
    EditUsuarioComponentComponent,

    perfil.PerfilComponent,
    perfil.PerfilGridComponent,
    tela.TelaComponent,
    tela.TitleComponent,
    tela.TelaContentComponent,
    tela.TelaGridComponent,
    tela.EditTelaComponentComponent,
    user.UsuarioComponent,
    user.UsuarioEditModalComponent,
    emp.EmpresaComponent,
    emp.EmpresaGridComponent,
    emp.EditEmpresaComponentComponent,
    emp.EmpresaContentComponent,
    parametro.ParametroComponent,
    parametro.ParametroGridComponent,
    parametro.ParametroContentComponent,
    parametro.EditParametroComponentComponent,
    diretorio.DiretorioComponent,
    diretorio.DiretorioContentComponent,
    diretorio.DiretorioGridComponent,
    diretorio.EditDiretorioComponentComponent,

  ],
  bootstrap: [perfil.PerfilComponent],
  exports: [tela.TitleComponent],
})
export class SegurancaModule {}
