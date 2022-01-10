import { Injectable } from '@angular/core';
import { Observable, Subject } from 'rxjs';

@Injectable({
    providedIn: 'root',
})
export class GlobalMenuService<T> {
    constructor() {}

    observavel: Subject<T> = new Subject<T>();

    setObservable(value: T) {
        this.observavel.next(value);
    }

    getObservable = (): Observable<T> => this.observavel.asObservable();

    set(value: T) {
        this.setObservable(value);
    }
}
