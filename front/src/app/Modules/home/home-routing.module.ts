import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { homePages } from './Pages/homePages';

const routes: Routes = homePages;

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class HomeRoutingModule { }
