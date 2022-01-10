import { Injectable } from '@angular/core';
import { IDiretorio } from 'src/app/Domain/Models/IDiretorio';
import { IResponse } from 'src/app/Domain/Models/IResponse';
import {
    Delete,
    DirectoryCreate,
    DirectoryUpdate,
    GetAll,
} from './Actions/directory';

@Injectable({
    providedIn: 'root',
})
export class DirectoryService {
    constructor() {}

    public async getDirectory(
        page: number,
        pageSize: number
    ): Promise<IResponse<IDiretorio[]>> {
        return await GetAll(page, pageSize);
    }

    public async deleteDirectory(id: number): Promise<IResponse<boolean>> {
        return await Delete(id);
    }
    public async updateDirectory(
        parameter: IDiretorio
    ): Promise<IResponse<boolean>> {
        const result = await DirectoryUpdate(parameter);
        return result;
    }
    public async createDirectory(
        parameter: IDiretorio
    ): Promise<IResponse<boolean>> {
        const result = await DirectoryCreate(parameter);
        return result;
    }
}
