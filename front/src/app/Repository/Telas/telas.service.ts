import { Injectable } from '@angular/core';
import axios from 'axios';

@Injectable({
  providedIn: 'root',
})
export class TelasService {
  constructor() {}

  getAll() {
    return axios.get('http://localhost:4200/assets/mocks/telas.json');
  }
}
