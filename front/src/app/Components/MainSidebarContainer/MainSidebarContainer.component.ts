import { IEmpresa } from './../../Domain/Models/IEmpresa';
import { TelasService } from './../../Repository/Telas/telas.service';
import { Component, OnInit } from '@angular/core';
import { Tela } from 'src/app/Models/Tela';
import { IUser } from '../../Domain/Models/IUser';
import { UserService } from 'src/app/Modules/seguranca/Services/user.service';
import { AuthenticationService } from 'src/app/Modules/login/Services/Authentication.service';
import { UserGlobal } from 'src/app/Shared';
import { IUsuarioEmp } from 'src/app/Domain/Models/IUsuarioEmp';

@Component({
    selector: 'app-MainSidebarContainer',
    templateUrl: './MainSidebarContainer.component.html',
    styleUrls: ['./MainSidebarContainer.component.scss'],
})
export class MainSidebarContainerComponent implements OnInit {
    screens: Tela[] = [];
    user?: IUser;
    selectCompany!: number;

    empresas: IEmpresa[] = [];

    isLoading = false;
    angle = 0;
    constructor(
    private telasservice: TelasService,
    private userService: UserService,
    private authenticationService: AuthenticationService,
    private userG: UserGlobal<IUser>
    ) {}

    async ngOnInit() {
        this.isLoading = true;
        await this.getUser();
        await this.getAll();
        this.isLoading = false;
    }
    checkLoadindState() {
        if (this.isLoading) {
            return 'in';
        } else {
            return 'd-none';
        }
    }
    async getUser(): Promise<void> {
        const token = this.authenticationService.getToken() || '';
        const user = await this.userService.getUserByToken(token);
        this.user = user.data;
        const e: IUsuarioEmp[] = [];
        this.userG.setObservable(this.user || ({ usuarioEmp: e } as IUser));
        // @ts-ignore: Unreachable code error
        AuthenticationService.setGlogalUser(user.data);
    //console.table(AuthenticationService.getGlobalUser());
    }

    async getAll() {
        if (this.user) {
            const screens: Tela[] = await this.telasservice.getAll(
                this.user.perfilId
            );

            this.screens = screens.map((screen) => Tela.fromJson(screen));

            const granScreens = screens.filter((e) => e.nivel);
            const subScreens = screens.filter((e) => !e.nivel);

            granScreens.forEach((e, i) => {
                const related = subScreens.filter((sub) => sub.telaId == e.id);
                related.sort((a, b) => (b.ordem > a.ordem ? -1 : 1));
                granScreens[i].relateds = related;
            });
            granScreens.sort((a, b) => (b.ordem > a.ordem ? -1 : 1));
            this.screens = granScreens;
        }
    }

    checkRouteModule(route: string): boolean {
        if (route) {
            const result = location.pathname.includes(route);

            return result;
        }
        return false;
    }

    onChange(id: number) {
        this.selectCompany = id;
    }
}
