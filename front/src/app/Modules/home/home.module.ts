import { NavBarComponent } from './Components/NavBar/NavBar.component';
import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { HomeRoutingModule } from './home-routing.module';
import { HomePageComponent } from './Components/HomePage/HomePage.component';
import { MainSidebarContainerComponent } from './Components/MainSidebarContainer/MainSidebarContainer.component';


@NgModule({
  declarations: [
    HomePageComponent,
    NavBarComponent,
    MainSidebarContainerComponent
  ],
  imports: [
    CommonModule,
    HomeRoutingModule
  ]
,
  bootstrap: [HomePageComponent]
})
export class HomeModule { }
