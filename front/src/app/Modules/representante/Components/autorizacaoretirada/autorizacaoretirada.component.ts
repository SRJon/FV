import { Component, OnInit } from '@angular/core';
import { GlobalTitle } from 'src/app/Shared/GlobalTitle';

@Component({
    selector: 'app-autorizacaoretirada',
    templateUrl: './autorizacaoretirada.component.html',
    styleUrls: ['./autorizacaoretirada.component.scss'],
})
export class AutorizacaoretiradaComponent implements OnInit {
    title = 'Autorização de Retirada';
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
