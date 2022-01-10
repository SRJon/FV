import { Component, OnInit } from '@angular/core';
import { GlobalTitle } from 'src/app/Shared/GlobalTitle';

@Component({
    selector: 'app-book',
    templateUrl: './book.component.html',
    styleUrls: ['./book.component.scss'],
})
export class BookComponent implements OnInit {
    title = 'Book';
    description = '';
    _title = '';

    constructor(private globalTitle: GlobalTitle<string>) {
        this.globalTitle.setValue(this.title);
    }

    getHeigth(): number {
        const doc = document.querySelector('#middleWrapper');
        return doc ? doc.clientHeight : 0;
    }

    ngOnInit(): void {}
}
