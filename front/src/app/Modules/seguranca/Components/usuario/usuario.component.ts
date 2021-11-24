import { Component, OnInit } from '@angular/core';
import { Grid } from 'src/app/Shared';
import { UserService } from '../../Services/user.service';
import { IUser } from '../../../../Domain/Models/IUser';

@Component({
  selector: 'app-usuario',
  templateUrl: './usuario.component.html',
  styleUrls: ['./usuario.component.scss'],
})
export class UsuarioComponent implements OnInit {
  IsOpen: boolean = true;
  listGrid: any[] = [];
  listTitle: string[];
  grid: Grid;
  selectedUser: IUser;
  isDiposed: boolean = false;

  constructor(private service: UserService) {
    this.selectedUser = this.makeEmptyUser();
    this.grid = new Grid();
    this.grid.sharePaginate.setHtml('.pagination');

    this.listTitle = ['id', 'nome', 'email', 'ativo'];
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
      console.log(this.listGrid);
    }
  }
  getType(type: string): string {
    return (typeof type).trim();
  }
  ngOnInit(): void {
    // this.grid.createGrid({ selectorHtml: '#table_user', paging: false });
    this.getAll();
    this.grid.createGrid({ selectorHtml: '#table_user', paging: false });
    this.grid.sharePaginate.setHtml('.pagination');
    // this.grid.sharePaginate.setPaginate();
  }
}
