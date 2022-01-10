import { Injectable } from '@angular/core';
import { IPerfil } from 'src/app/Domain/Models/IPerfil';
import { IResponse } from 'src/app/Domain/Models/IResponse';
import * as actions from './Actions';

@Injectable({
    providedIn: 'root',
})
export class PerfilService {
    constructor() {}

    public async getAllPerfil(
        page: number,
        pageSize: number
    ): Promise<IResponse<IPerfil[]>> {
        return await actions.perfil.PerfilGetAll(page, pageSize);
    }

    public async getAllNamesPerfil(
        page: number,
        pageSize: number
    ): Promise<IResponse<IPerfil[]>> {
        return await actions.perfil.PerfilGetAllNames(page, pageSize);
    }

    public async deletePerfil(id: number): Promise<IResponse<boolean>> {
        return await actions.perfil.PerfilDelete(id);
    }

    public async updatePerfil(perfil: IPerfil): Promise<IResponse<boolean>> {
        const result = await actions.perfil.PerfilUpdate(perfil);
        return result;
    }

    public async createPerfil(perfil: IPerfil): Promise<IResponse<boolean>> {
        const result = await actions.perfil.PerfilCreate(perfil);
        return result;
    }
}
