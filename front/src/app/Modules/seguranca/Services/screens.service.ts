import { Injectable } from '@angular/core';
import { ITela } from '../../../Domain/Models/ITela';
import { IResponse } from '../../../Domain/Models/IResponse';
import { Delete, GetAll } from './Actions';

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
}
