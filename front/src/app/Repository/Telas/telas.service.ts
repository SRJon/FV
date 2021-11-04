import { Injectable } from '@angular/core';
import axios from 'axios';
import { ITela } from '../../Domain/Models/ITela';

@Injectable({
  providedIn: 'root',
})
export class TelasService {
  constructor() {}

  async getAll(): Promise<ITela[]> {
    return await axios
      .get('api/Tela?page=0&limit=0')
      .then((response) => response.data.data);
  }
}
