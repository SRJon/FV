import { Component, OnInit } from '@angular/core';
import { IEmpresa } from 'src/app/Domain/Models/IEmpresa';
import { IUser } from 'src/app/Domain/Models/IUser';
import { UserGlobal } from 'src/app/Shared';

@Component({
  selector: 'app-NavBar',
  templateUrl: './NavBar.component.html',
  styleUrls: ['./NavBar.component.scss'],
})
export class NavBarComponent implements OnInit {
  empresas: IEmpresa[] = [
    // {
    //   id: 1,
    //   nome: 'Litoral Têxtil',
    //   vlrMinFrete: 0,
    //   vlrMinPedido: 0,
    //   codEmp: 1,
    // },
    // {
    //   id: 2,
    //   nome: 'Maioral Têxtil',
    //   vlrMinFrete: 0,
    //   vlrMinPedido: 0,
    //   codEmp: 2,
    // },
  ];

  constructor(private userG: UserGlobal<IUser>) {}

  ngOnInit() {
    this.userG.getObservable().subscribe((user) => {
      let emp = user.usuarioEmp;

      if (emp?.length) {
        let getEmps = emp.map((e) => e.empresa);

        let nonNUll = getEmps.filter((e) => e != undefined) as IEmpresa[];
        this.empresas = nonNUll;
      }
    });
  }
}
