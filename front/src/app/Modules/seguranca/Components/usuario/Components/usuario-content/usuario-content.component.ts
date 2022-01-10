import { Component, OnInit } from '@angular/core';
import { IResponse } from 'src/app/Domain/Models/IResponse';
import { IUser } from 'src/app/Domain/Models/IUser';
import { Paginate } from 'src/app/Domain/Models/Paginate';
import { UserService } from 'src/app/Modules/seguranca/Services/user.service';

@Component({
  selector: 'app-usuario-content',
  templateUrl: './usuario-content.component.html',
  styleUrls: ['./usuario-content.component.scss'],
})
export class UsuarioContentComponent implements OnInit {
  usuarios: IResponse<IUser[]>;
  paginate: Paginate;
  isOpen: boolean = false;
  initialParam: IUser = {} as IUser;

  constructor(private userService: UserService) {
    this.usuarios = {} as IResponse<IUser[]>;
    this.paginate = new Paginate(1, 1);

    this.initialParam = {
      id: 0,
      login: '',
      senha: '',
      nome: '',
      email: '',
      ativo: false,
      perfilId: 0,
      vendedorUCod: 0,
      altSenha: false,
      dtUltAltSenha: new Date(),
      loginSnk: '',
      sgtsiusU_USU_COD: 0,
      senhaFV: '',
    };
  }
  ngOnInit(): void {
    this.getAll(1);
  }

  openModal(isClose: boolean) {
    this.isOpen = !isClose;
    if (isClose) {
      this.getAll(this.paginate.currentPage);
    }
  }
  getAll(page: number, limit: number = 10) {
    this.userService.getUser(page, limit).then((response) => {
      this.usuarios = response;
      this.paginate.pageSize = response.totalPages;
      this.paginate.totalItems = response.totalPages * limit;
      this.paginate.setPage();
    });
  }

  onNextSelection(page: number) {
    this.paginate.currentPage = page;
    this.getAll(page);
  }
}
