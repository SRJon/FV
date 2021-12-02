import { Component, OnInit } from '@angular/core';
import { AsideMenu } from 'src/app/Models/AsideMenu';
import { GlobalMenuService } from 'src/app/Shared/global-menu.service';

@Component({
  selector: 'app-NavBar',
  templateUrl: './NavBar.component.html',
  styleUrls: ['./NavBar.component.scss'],
})
export class NavBarComponent implements OnInit {
  isOpen = false;
  aside = new AsideMenu();
  constructor(private menuAsideObs: GlobalMenuService<AsideMenu>) {}

  ngOnInit() {}

  onMenuClickModal() {
    this.isOpen = !this.isOpen;
    this.aside.setValue(this.isOpen);
    this.menuAsideObs.set(this.aside);
  }
}
