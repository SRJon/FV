import { Component, OnInit } from '@angular/core';
import { Grid } from 'src/app/Shared';
import { UserService } from '../../Services/user.service';

@Component({
  selector: 'app-usuario',
  templateUrl: './usuario.component.html',
  styleUrls: ['./usuario.component.scss'],
})
export class UsuarioComponent implements OnInit {
  listGrid: any[] = [
    {
      nome: 'sss',
      email: 'sss',
    },
  ];
  grid: Grid;

  constructor(private service: UserService) {
    this.grid = new Grid();
    this.service.getAll(1, 1);
  }

  ngOnInit(): void {
    this.grid.createGrid({ selectorHtml: '#table_user', paging: false });

    this.grid.sharePaginate.setHtml('.pagination');
    this.grid.sharePaginate.setPaginate();
  }
}
