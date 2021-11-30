import { TelasService } from './../../Repository/Telas/telas.service';
import { Component, OnInit } from '@angular/core';
import { Tela } from 'src/app/Models/Tela';
import { IUser } from '../../Domain/Models/IUser';
import { UserService } from 'src/app/Modules/seguranca/Services/user.service';
import { AuthenticationService } from 'src/app/Modules/login/Services/Authentication.service';

@Component({
  selector: 'app-MainSidebarContainer',
  templateUrl: './MainSidebarContainer.component.html',
  styleUrls: ['./MainSidebarContainer.component.scss'],
})
export class MainSidebarContainerComponent implements OnInit {
  screens: Tela[] = [];
  user?: IUser;

  constructor(
    private telasservice: TelasService,
    private userService: UserService,
    private authenticationService: AuthenticationService
  ) {}

  async ngOnInit() {
    await this.getUser();
    this.getAll();
  }

  async getUser(): Promise<void> {
    let token = this.authenticationService.getToken() || '';
    let user = await this.userService.getUserByToken(token);
    this.user = user.data;
  }

  async getAll() {
    if (this.user) {
      let screens: Tela[] = await this.telasservice.getAll(this.user.perfilId);

      this.screens = screens.map((screen) => Tela.fromJson(screen));

      let granScreens = screens.filter((e) => e.nivel);
      let subScreens = screens.filter((e) => !e.nivel);

      granScreens.forEach((e, i) => {
        let related = subScreens.filter((sub) => sub.telaId == e.id);
        console.log(related, e.id);

        related.sort((a, b) => (b.ordem > a.ordem ? -1 : 1));
        // console.log(related.map((e) => e.ordem));
        // console.log(related);

        granScreens[i].relateds = related;
      });
      granScreens.sort((a, b) => (b.ordem > a.ordem ? -1 : 1));
      this.screens = granScreens;
    }
  }

  checkRouteModule(route: string): boolean {
    if (!!route) {
      var result = location.pathname.includes(route);

      return result;
    }
    return false;
  }
}
