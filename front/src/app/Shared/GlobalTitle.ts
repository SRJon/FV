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

  setValue(value: T) {
    this.setObservable(value);
  }
}
