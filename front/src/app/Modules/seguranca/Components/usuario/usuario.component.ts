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
  constructor(
    private titleService: Title,
    private globalTitle: GlobalTitle<string>
  ) {
    this.titleService.setTitle(this.title);
    this.globalTitle.getObservable().subscribe((value) => {
      this._title = value;
    });
  }

  getHeigth(): number {
    let doc = document.querySelector('#middleWrapper');
    return doc ? doc.clientHeight : 0;
  }

  ngOnInit(): void {
    this.globalTitle.setValue(this.title);
  }
}
