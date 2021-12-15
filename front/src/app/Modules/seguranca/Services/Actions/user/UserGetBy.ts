import axios from 'axios';
import { IResponse } from '../../../../../Domain/Models/IResponse';
import { IUser } from '../../../../../Domain/Models/IUser';

export async function UserGetById(id: number): Promise<IResponse<IUser>> {
  let response = await axios.get(`/api/Usuario/${id}`);
  return response.data;
}
