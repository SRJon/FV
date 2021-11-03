import { NavBarComponent } from './Components/NavBar/NavBar.component';
import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { HomeRoutingModule } from './home-routing.module';
import { HomePageComponent } from './Components/HomePage/HomePage.component';


@NgModule({
  declarations: [HomePageComponent,NavBarComponent],
  imports: [
    CommonModule,
    HomeRoutingModule
  ]
,
  bootstrap: [HomePageComponent]
})
export class HomeModule { }
