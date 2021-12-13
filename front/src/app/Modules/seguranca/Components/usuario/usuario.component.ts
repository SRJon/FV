import { Component, OnInit } from '@angular/core';
import { Grid } from 'src/app/Shared';
import { UserService } from '../../Services/user.service';
import { IUser } from '../../../../Domain/Models/IUser';
import { AlertsService } from '../../../../Repository/Alerts/alerts.service';
import { Title } from '@angular/platform-browser';
import { GlobalTitle } from 'src/app/Shared/GlobalTitle';
@Component({
  selector: 'app-usuario',
  templateUrl: './usuario.component.html',
  styleUrls: ['./usuario.component.scss'],
})
export class UsuarioComponent implements OnInit {
  title: string = 'Usuário';
  description: string = '';
  _title: string = '';
  IsOpen: boolean = false;
  listGrid: any[] = [];
  listTitle: string[];
  grid: Grid;
  selectedUser: IUser;
  isDiposed: boolean = false;
  modalIsOpen: boolean = false;

  constructor(
    private titleService: Title,
    private service: UserService,
    private alertsService: AlertsService,
    private globalTitle: GlobalTitle<string>
  ) {
    this.titleService.setTitle(this.title);
    this.selectedUser = this.makeEmptyUser();
    this.grid = new Grid();
    this.grid.sharePaginate.setHtml('.pagination');
    this.listTitle = ['id', 'nome', 'email', 'ativo'];
    this.globalTitle.getObservable().subscribe((value) => {
      this._title = value;
    });
  }
  changeModalDeleteState(isOpen: boolean, IUser: IUser | null = null) {
    this.modalIsOpen = isOpen;
    if (IUser) {
      this.selectedUser = this.cloneUser(IUser);
    }
  }
  onModalChange(isOpen: boolean) {
    this.IsOpen = isOpen;
  }
  onDispose(isDiposed: boolean) {
    this.isDiposed = isDiposed;
    this.selectedUser = this.makeEmptyUser();
    this.IsOpen = false;
    this.getAll(this.grid.sharePaginate.paginate.currentPage);
  }
  cloneUser(user: IUser): IUser {
    return { ...user };
  }
  openModal(user: IUser | null) {
    if (user) {
      this.selectedUser = this.cloneUser(user);
    } else {
      this.selectedUser = this.makeEmptyUser();
    }
    this.IsOpen = true;
    this.isDiposed = false;
  }
  makeEmptyUser(): IUser {
    return {
      id: 0,
      login: '',
      senha: '',
      nome: '',
      email: '',
      ativo: false,
    } as IUser;
  }
  async getAll(page = 1) {
    var response = await this.service.getAll(page, 10);

    if (response) {
      this.listGrid = response.data;
      this.grid.sharePaginate.setAttr(response);
      this.grid.sharePaginate.setPaginate((p) => this.getAll(p));
      this.grid.render();
    }
  }
  getType(type: string): string {
    return (typeof type).trim();
  }

  public async deleteUser(user: IUser) {
    var response = await this.service.delete(user.id);

    if (response) {
      this.alertsService.showAlert(
        response.data
          ? 'Deletado com sucesso'
          : 'Usuario não pode ser deletado',
        response.data ? 'success' : 'error'
      );
      this.getAll();
      this.changeModalDeleteState(false);
    }
  }
  ngOnInit(): void {
    // this.grid.createGrid({ selectorHtml: '#table_user', paging: false });
    this.getAll();
    this.grid.createGrid({ selectorHtml: '#table_user', paging: false });
    this.grid.sharePaginate.setHtml('.pagination');
    // this.grid.sharePaginate.setPaginate();
    this.globalTitle.setValue(this.title);
  }
}
