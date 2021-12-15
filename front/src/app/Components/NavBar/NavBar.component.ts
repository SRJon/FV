import { Component, OnInit } from '@angular/core';

import { IEmpresa } from 'src/app/Domain/Models/IEmpresa';
import { IUser } from 'src/app/Domain/Models/IUser';
import { UserGlobal } from 'src/app/Shared';

import { AsideMenu } from 'src/app/Models/AsideMenu';
import { GlobalMenuService } from 'src/app/Shared/global-menu.service';
import { GlobalTitle } from 'src/app/Shared/GlobalTitle';

@Component({
  selector: 'app-NavBar',
  templateUrl: './NavBar.component.html',
  styleUrls: ['./NavBar.component.scss'],
})
export class NavBarComponent implements OnInit {
  empresas: IEmpresa[] = [];
  selectedEmpresa: IEmpresa | undefined;
  isOpen = false;
  aside = new AsideMenu();
  _title = '';

  constructor(
    private menuAsideObs: GlobalMenuService<AsideMenu>,
    private globalTitle: GlobalTitle<string>,
    private userG: UserGlobal<IUser>
  ) {}
  ngOnInit() {
    this.userG.getObservable().subscribe((user) => {
      let emp = user.usuarioEmp;

      if (emp?.length) {
        let getEmps = emp.map((e) => e.empresa);

        let nonNUll = getEmps.filter((e) => e != undefined) as IEmpresa[];
        this.empresas = nonNUll;

        //Alterar posteriormente para armazenar a empresa principal do usuário
        this.selectedEmpresa = this.empresas[0];
      }
    });

    this.globalTitle.getObservable().subscribe((value) => {
      this._title = value;
    });
  }
  onMenuClickModal() {
    this.isOpen = !this.isOpen;
    this.aside.setValue(this.isOpen);
    this.menuAsideObs.set(this.aside);
  }

  onChange(empresa: IEmpresa) {
    this.selectedEmpresa === empresa;
  }
}
