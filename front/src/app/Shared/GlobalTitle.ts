import { Injectable } from '@angular/core';
import { Observable, Subject } from 'rxjs';

@Injectable({
    providedIn: 'root',
})
export class GlobalTitle<T> {
    observavel: Subject<T> = new Subject<T>();

    constructor() {}
    setObservable(value: T) {
        this.observavel.next(value);
    }

    getObservable = (): Observable<T> => this.observavel.asObservable();
    getObs = (f: any) => {
        const ff = (value: T) => {
            f(value);
        };
        return this.getObservable().subscribe(ff);
    };
    setValue(value: T) {
        setTimeout(() => {
            const titleDom = document.querySelector('title') as HTMLTitleElement;
            titleDom.innerHTML = String(value);

            this.setObservable(value);
            // this.updateMessage();
        }, 1);
    }
}
