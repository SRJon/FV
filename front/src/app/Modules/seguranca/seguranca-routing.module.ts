import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { Route } from './Pages/Route';

const routes: Routes = new Route().getRoutes();

@NgModule({
    imports: [RouterModule.forChild(routes)],
    exports: [RouterModule],
})
export class SegurancaRoutingModule {}
