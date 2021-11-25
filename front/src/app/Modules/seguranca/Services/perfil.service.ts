import { Injectable } from '@angular/core';
import { IPerfil } from 'src/app/Domain/Models/IPerfil';
import { IResponse } from 'src/app/Domain/Models/IResponse';
import { getallNames } from './Actions/perfil/perfilGetAllOnly';

@Injectable({
  providedIn: 'root',
})
export class PerfilService {
  constructor() {}

  async getAllNames(
    page: number,
    limit: number
  ): Promise<IResponse<IPerfil[]>> {
    var response = getallNames(page, limit);
    return response;
  }
}
