import { Injectable } from '@angular/core';
import { IResponse } from 'src/app/Domain/Models/IResponse';
import { IUser } from 'src/app/Domain/Models/IUser';
import * as actions from './Actions';

@Injectable({
  providedIn: 'root',
})
export class UserService {
  constructor() {}

  public async getAll(
    page = 1,
    limit = 1
  ): Promise<IResponse<IUser[]> | undefined> {
    try {
      var result = await actions.user.GetAll(page, limit);
      return result;
    } catch (error) {
      return undefined;
    }
  }

  public async getById(id: number): Promise<IResponse<IUser> | undefined> {
    try {
      var result = await actions.user.GetById(id);
      return result;
    } catch (error) {
      return undefined;
    }
  }

  public async update(user: IUser): Promise<IResponse<boolean>> {
    try {
      var result = await actions.user.update(user);
      return result;
    } catch (error: any) {
      return {
        data: false,
        message: error.response.data.message,
      } as IResponse<boolean>;
    }
  }

  public async create(user: IUser): Promise<IResponse<boolean>> {
    try {
      var result = await actions.user.create(user);
      return result;
    } catch (error: any) {
      return {
        data: false,
        message: error.response.data.message,
      } as IResponse<boolean>;
    }
  }
}
