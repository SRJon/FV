import { ITGFRGV } from './../../../Domain/Models/ITGFRGV';
import { Injectable } from '@angular/core';
import { IResponse } from 'src/app/Domain/Models/IResponse';
import { getCodGrupoProd } from './Actions/stock';

@Injectable({
  providedIn: 'root',
})
export class StockService {
  constructor() {}

  public async getCodGrupoProd(CodVend: number): Promise<IResponse<ITGFRGV[]>> {
    return await getCodGrupoProd(CodVend);
  }
}
