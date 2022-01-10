import { Component, OnInit } from '@angular/core';
import { GlobalTitle } from 'src/app/Shared/GlobalTitle';

@Component({
    selector: 'app-iniciorepresentante',
    templateUrl: './iniciorepresentante.component.html',
    styleUrls: ['./iniciorepresentante.component.scss'],
})
export class IniciorepresentanteComponent implements OnInit {
    title = 'Início';
    description = '';
    _title = '';

    constructor(private globalTitle: GlobalTitle<string>) {
        this.globalTitle.setValue(this.title);
    }

    ngOnInit(): void {}
}
