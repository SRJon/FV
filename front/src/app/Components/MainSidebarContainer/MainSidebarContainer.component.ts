import { TelasService } from './../../Repository/Telas/telas.service';
import { Component, OnInit } from '@angular/core';
import { Tela } from 'src/app/Models/Tela';
import { IUser } from '../../Domain/Models/IUser';

@Component({
  selector: 'app-MainSidebarContainer',
  templateUrl: './MainSidebarContainer.component.html',
  styleUrls: ['./MainSidebarContainer.component.scss'],
})
export class MainSidebarContainerComponent implements OnInit {
  screens: Tela[] = [];
  user?: IUser;

  constructor(private telasservice: TelasService) {
    this.getAll();
  }

  ngOnInit() {}

  async getAll() {
    let screens: Tela[] = await this.telasservice.getAll();

    this.screens = screens.map((screen) => Tela.fromJson(screen));

    let granScreens = screens.filter((e) => e.nivel);
    let subScreens = screens.filter((e) => !e.nivel);

    granScreens.forEach((e, i) => {
      let related = subScreens.filter((sub) => sub.telaId == e.id);

      granScreens[i].relateds = related;
    });
    this.screens = granScreens;
  }

  checkRouteModule(route: string): boolean {
    if (!!route) {
      var result = location.pathname.includes(route);

      return result;
    }
    return false;
  }
}
