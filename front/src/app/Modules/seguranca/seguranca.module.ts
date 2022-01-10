import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { SegurancaRoutingModule } from './seguranca-routing.module';

import { FormsModule, ReactiveFormsModule } from '@angular/forms';

import * as perfil from './Components/perfil';
import * as tela from './Components/tela';
import * as diretorio from './Components/diretorio';
import * as parametro from './Components/parametro';
import * as emp from './Components/empresa';
import * as user from './Components/usuario';
import { EditPerfilComponentComponent } from './Components/perfil/Components/perfil-content/edit-perfil-component/edit-perfil-component.component';

@NgModule({
    imports: [
        CommonModule,
        SegurancaRoutingModule,
        FormsModule,
        ReactiveFormsModule,
    ],
    declarations: [
        perfil.PerfilComponent,
        perfil.PerfilGridComponent,
        tela.TelaComponent,
        tela.TelaContentComponent,
        tela.TelaGridComponent,
        tela.EditTelaComponentComponent,
        // user.UsuarioComponent,
        // user.EditUsuarioComponentComponent,
        // user.UsuarioContentComponent,
        ...user.default,
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
        perfil.PerfilComponent,
        perfil.PerfilGridComponent,
        perfil.EditPerfilComponentComponent,
        perfil.PerfilContentComponent,
    ],
    bootstrap: [perfil.PerfilComponent],
})
export class SegurancaModule {}
