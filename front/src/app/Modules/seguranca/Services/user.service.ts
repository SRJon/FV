import { Injectable } from '@angular/core';
import * as actions from './Actions';

@Injectable({
  providedIn: 'root',
})
export class UserService {
  constructor() {}

  public async getAll(page = 1, limit = 1) {
    var result = await actions.user.GetAll(page, limit);
  }
}
