import { Component, OnInit } from '@angular/core';
import { GlobalTitle } from 'src/app/Shared/GlobalTitle';

@Component({
    selector: 'app-empresa',
    templateUrl: './empresa.component.html',
    styleUrls: ['./empresa.component.scss'],
})
export class EmpresaComponent implements OnInit {
    title = 'Empresa';
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
