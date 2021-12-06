import { IEmpresa } from './../../../Domain/Models/IEmpresa';
import { IResponse } from './../../../Domain/Models/IResponse';
import { Injectable } from '@angular/core';
import { CompanyCreate, CompanyUpdate, GetAll } from './Actions/company';
import { Delete } from './Actions/company';

@Injectable({
  providedIn: 'root',
})
export class CompanyService {
  constructor() {}

  public async getCompany(
    page: number,
    pageSize: number
  ): Promise<IResponse<IEmpresa[]>> {
    return await GetAll(page, pageSize);
  }

  public async deleteCompany(id: number): Promise<IResponse<boolean>> {
    return await Delete(id);
  }

  public async updateCompany(company: IEmpresa): Promise<IResponse<boolean>> {
    var result = await CompanyUpdate(company);
    return result;
  }

  public async createCompany(company: IEmpresa): Promise<IResponse<boolean>> {
    var result = await CompanyCreate(company);
    return result;
  }
}
