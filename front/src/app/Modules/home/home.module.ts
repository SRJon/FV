import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { HomeRoutingModule } from './home-routing.module';
import { HomePageComponent } from './Components/HomePage/HomePage.component';
import { HeaderPlotComponent } from './Components/HomePage/plots/header-plot/header-plot.component';
import { NotificationPlotComponent } from './Components/HomePage/plots/notification-plot/notification-plot.component';
import { SalesPlotComponent } from './Components/HomePage/plots/sales-plot/sales-plot.component';

@NgModule({
  declarations: [HomePageComponent, HeaderPlotComponent, NotificationPlotComponent, SalesPlotComponent],
  imports: [CommonModule, HomeRoutingModule],
  bootstrap: [HomePageComponent],
})
export class HomeModule {}
