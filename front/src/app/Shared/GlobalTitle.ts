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
    let ff = (value: T) => {
      (document.querySelector('title') as HTMLTitleElement).innerHTML =
        String(value);
      f(value);
    };
    return this.getObservable().subscribe(ff);
  };
  setValue(value: T) {
    this.setObservable(value);
  }
}
