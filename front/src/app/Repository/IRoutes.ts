import { Routes } from '@angular/router';

export interface IRoutes {
  readonly routes: Routes;
  getRoutes(): Routes;
}
