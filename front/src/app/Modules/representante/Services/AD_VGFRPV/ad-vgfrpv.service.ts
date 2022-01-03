import { Injectable } from '@angular/core';
import { IAvgfrpvgetall } from 'src/app/Domain/Models/IAvgfrpvgetall';
import { Pedido } from 'src/app/Domain/Models/IPedido';
import { IResponse } from 'src/app/Domain/Models/IResponse';
import * as actions from './Action';

@Injectable({
  providedIn: 'root',
})
export class ADVGFRPVService {
  constructor() {}

  async getAll(page = 1, limit = 10): Promise<IResponse<IAvgfrpvgetall[]>> {
    return await actions.AVGFRPVGETALL(page, limit);
  }

  async GetByVend(codVend: number = 1): Promise<IResponse<IAvgfrpvgetall>> {
    return await actions.GetByVend(codVend);
  }
  async GetByParc(codParc: number = 1): Promise<IResponse<IAvgfrpvgetall>> {
    return await actions.GetByParc(codParc);
  }
  async GetAllByCodParc(
    codParc: number = 1,
    page: number = 1,
    limit: number = 10
  ): Promise<IResponse<Pedido[]>> {
    return await actions.GetAllByCodParc(codParc, page, limit);
  }
  async GetAllNF(codParc: number, page: number, limit: number) {
    return await actions.GetAllNF(codParc, page, limit);
  }
}
