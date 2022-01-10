import { Component, OnInit } from '@angular/core';
import { GlobalTitle } from 'src/app/Shared/GlobalTitle';
@Component({
    selector: 'app-usuario',
    templateUrl: './usuario.component.html',
    styleUrls: ['./usuario.component.scss'],
})
export class UsuarioComponent implements OnInit {
    title = 'Usuário';
    description = '';

    constructor(private globalTitle: GlobalTitle<string>) {
        this.globalTitle.setValue(this.title);
    }

    getHeigth(): number {
        const doc = document.querySelector('#middleWrapper');
        return doc ? doc.clientHeight : 0;
    }

    ngOnInit(): void {}
}
