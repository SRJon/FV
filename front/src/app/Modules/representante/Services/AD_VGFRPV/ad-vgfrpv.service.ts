import { Injectable } from '@angular/core';
import { IAvgfrpvgetall } from 'src/app/Domain/Models/IAvgfrpvgetall';
import { IResponse } from 'src/app/Domain/Models/IResponse';
import { AVGFRPVGETALL } from './Action';

@Injectable({
  providedIn: 'root',
})
export class ADVGFRPVService {
  constructor() {}

  async getAll(page = 1, limit = 10): Promise<IResponse<IAvgfrpvgetall[]>> {
    return await AVGFRPVGETALL(page, limit);
  }
}
