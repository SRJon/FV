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
      var result = await actions.user.UserGetAll(page, limit);
      return result;
    } catch (error) {
      return undefined;
    }
  }

  public async getById(id: number): Promise<IResponse<IUser> | undefined> {
    try {
      var result = await actions.user.UserGetById(id);
      return result;
    } catch (error) {
      return undefined;
    }
  }

  public async update(user: IUser): Promise<IResponse<boolean>> {
    try {
      var result = await actions.user.UserUpdate(user);
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
      var result = await actions.user.UserCreate(user);
      return result;
    } catch (error: any) {
      return {
        data: false,
        message: error.response.data.message,
      } as IResponse<boolean>;
    }
  }

  public async delete(id: number): Promise<IResponse<boolean>> {
    try {
      var result = await actions.user.UserDelete(id);
      return result;
    } catch (error: any) {
      return {
        data: false,
        message: error.response.data.message,
      } as IResponse<boolean>;
    }
  }
  public async getUserByToken(
    token: string
  ): Promise<IResponse<IUser | undefined>> {
    var result = await actions.user.LoginGetUserByToken(token);
    if (result.data) {
      return result;
    } else {
      return {} as IResponse<IUser | undefined>;
    }
  }

  public async getUser(
    page: number,
    pageSize: number
  ): Promise<IResponse<IUser[]>> {
    return await actions.user.UserGetAll(page, pageSize);
  }

  public async deleteUser(id: number): Promise<IResponse<boolean>> {
    return await actions.user.UserDelete(id);
  }

  public async updateUser(user: IUser): Promise<IResponse<boolean>> {
    return await actions.user.UserUpdate(user);
  }

  public async createUser(user: IUser): Promise<IResponse<boolean>> {
    return await actions.user.UserCreate(user);
  }
}
