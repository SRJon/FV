import { Component, OnInit } from '@angular/core';
import { GlobalTitle } from 'src/app/Shared/GlobalTitle';

@Component({
    selector: 'app-comissao',
    templateUrl: './comissao.component.html',
    styleUrls: ['./comissao.component.scss'],
})
export class ComissaoComponent implements OnInit {
    title = 'Comissão';
    description = '';
    _title = '';

    constructor(private globalTitle: GlobalTitle<string>) {
        this.globalTitle.setValue(this.title);
    }

    ngOnInit(): void {}
}
