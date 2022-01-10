import { Component, OnInit } from '@angular/core';
import { GlobalTitle } from 'src/app/Shared/GlobalTitle';

@Component({
    selector: 'app-anexo',
    templateUrl: './anexo.component.html',
    styleUrls: ['./anexo.component.scss'],
})
export class AnexoComponent implements OnInit {
    title = 'Anexo';
    description = '';

    constructor(private globalTitle: GlobalTitle<string>) {
        this.globalTitle.setValue(this.title);
    }

    ngOnInit(): void {}
}
