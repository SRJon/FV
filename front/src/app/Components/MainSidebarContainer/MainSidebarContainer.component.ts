import { TelasService } from './../../Repository/Telas/telas.service';
import { Component, OnInit } from '@angular/core';
import { Tela } from 'src/app/Models/Tela';

@Component({
  selector: 'app-MainSidebarContainer',
  templateUrl: './MainSidebarContainer.component.html',
  styleUrls: ['./MainSidebarContainer.component.scss'],
})
export class MainSidebarContainerComponent implements OnInit {
  screens: Tela[] = [];

  constructor(private telasservice: TelasService) {
    this.getAll();
  }

  ngOnInit() {}

  async getAll() {
    let screens: Tela[] = await (await this.telasservice.getAll()).data;
    screens = screens.map((screen) =>
      Tela.getInstance(
        screen.SgTelaId,
        screen.TelaNome,
        screen.TelaUrl,
        screen.TelaAddUrl,
        screen.TelaTarget,
        screen.TelaNivel,
        screen.TelaOrdem,
        screen.TelaModulo,
        screen.TelaSD,
        screen.TelaImagemSD,
        screen.TelaIconClass,
        screen.SgTelaId
      )
    );

    let granScreens = screens.filter((e) => e.TelaNivel);
    let subScreens = screens.filter((e) => !e.TelaNivel);

    granScreens.forEach((e, i) => {
      let related = subScreens.filter((sub) => sub.SgTelaId == e.TelaId);

      granScreens[i].relateds = related;
    });
    this.screens = granScreens;
    console.log(this.screens);
  }
}
