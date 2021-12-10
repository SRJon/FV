import { Injectable } from '@angular/core';
import { IParametro } from '../../../Domain/Models/IParametro';
import { IResponse } from '../../../Domain/Models/IResponse';
import {
  Delete,
  GetAll,
  ParameterUpdate,
  ParameterCreate,
} from './Actions/parameter';

@Injectable({
  providedIn: 'root',
})
export class ParameterService {
  constructor() {}

  public async getParameter(
    page: number,
    pageSize: number
  ): Promise<IResponse<IParametro[]>> {
    return await GetAll(page, pageSize);
  }

  public async deleteParameter(id: number): Promise<IResponse<boolean>> {
    return await Delete(id);
  }
  public async updateParameter(
    parameter: IParametro
  ): Promise<IResponse<boolean>> {
    var result = await ParameterUpdate(parameter);
    return result;
  }
  public async createParameter(
    parameter: IParametro
  ): Promise<IResponse<boolean>> {
    var result = await ParameterCreate(parameter);
    return result;
  }
}
