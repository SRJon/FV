import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { MainSidebarContainerComponent } from './Components/MainSidebarContainer/MainSidebarContainer.component';
import { NavBarComponent } from './Components/NavBar/NavBar.component';

@NgModule({
  declarations: [AppComponent, NavBarComponent, MainSidebarContainerComponent],
  imports: [BrowserModule, AppRoutingModule],
  providers: [],
  bootstrap: [AppComponent],
})
export class AppModule {}
