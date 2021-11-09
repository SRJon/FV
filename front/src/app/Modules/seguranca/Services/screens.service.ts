import { Injectable } from '@angular/core';
import { ITela } from '../../../Domain/Models/ITela';
import { IResponse } from '../../../Domain/Models/IResponse';
import { GetAll } from './Actions/ScreenGetAll';

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
}
