import { Component, OnInit } from '@angular/core';
import { AsideMenu } from 'src/app/Models/AsideMenu';
import { GlobalMenuService } from 'src/app/Shared/global-menu.service';
import { GlobalTitle } from 'src/app/Shared/GlobalTitle';

@Component({
  selector: 'app-NavBar',
  templateUrl: './NavBar.component.html',
  styleUrls: ['./NavBar.component.scss'],
})
export class NavBarComponent implements OnInit {
  isOpen = false;
  aside = new AsideMenu();
  _title = '';
  constructor(
    private menuAsideObs: GlobalMenuService<AsideMenu>,
    private globalTitle: GlobalTitle<string>
  ) {}

  ngOnInit() {
    this.globalTitle.getObservable().subscribe((value) => {
      this._title = value;
    });
  }

  onMenuClickModal() {
    this.isOpen = !this.isOpen;
    this.aside.setValue(this.isOpen);
    this.menuAsideObs.set(this.aside);
  }
}
