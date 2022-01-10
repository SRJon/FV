import { Component, OnInit } from '@angular/core';
import { GlobalTitle } from 'src/app/Shared/GlobalTitle';

@Component({
    selector: 'app-pedidos',
    templateUrl: './pedidos.component.html',
    styleUrls: ['./pedidos.component.scss'],
})
export class PedidosComponent implements OnInit {
    title = 'Pedidos';
    description = '';

    constructor(private globalTitle: GlobalTitle<string>) {
        this.globalTitle.setValue(this.title);
    }

    ngOnInit(): void {}
}
