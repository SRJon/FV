import { Injectable } from '@angular/core';
import { ITela } from '../../../Domain/Models/ITela';
import { IResponse } from '../../../Domain/Models/IResponse';
import { Delete, GetAll, ScreenUpdate, ScreenCreate } from './Actions/screen';

@Injectable({
    providedIn: 'root',
})
export class ScreensService {
    constructor() {}

    public async getScreens(
        page: number,
        pageSize: number
    ): Promise<IResponse<ITela[]>> {
        return await GetAll(page, pageSize);
    }

    public async deleteScreen(id: number): Promise<IResponse<boolean>> {
        return await Delete(id);
    }
    public async updateScreen(screen: ITela): Promise<IResponse<boolean>> {
        const result = await ScreenUpdate(screen);
        return result;
    }
    public async createScreen(screen: ITela): Promise<IResponse<boolean>> {
        const result = await ScreenCreate(screen);
        return result;
    }
}
