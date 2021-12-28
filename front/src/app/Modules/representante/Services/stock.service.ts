import { IAD_ESTCODPROD } from './../../../Domain/Models/IAD_ESTCODPROD';
import { ITGFRGV } from './../../../Domain/Models/ITGFRGV';
import { Injectable } from '@angular/core';
import { IResponse } from 'src/app/Domain/Models/IResponse';
import * as actions from './Actions';
@Injectable({
  providedIn: 'root',
})
export class StockService {
  constructor() {}

  public async getCodGrupoProd(CodVend: number): Promise<IResponse<ITGFRGV[]>> {
    return await actions.stock.GetCodGrupoProd(CodVend);
  }

  public async getAdEstCodProd(
    page: number,
    limit: number,
    Produto: number,
    CodGrupoProd: number,
    DescrProd: string,
    ComplDesc: string
  ): Promise<IResponse<IAD_ESTCODPROD[]>> {
    return await actions.stock.GetAdEstCodProd(
      page,
      limit,
      Produto,
      CodGrupoProd,
      DescrProd,
      ComplDesc
    );
  }
}
