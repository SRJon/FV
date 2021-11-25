import axios from 'axios';
import { IResponse } from '../../../../../Domain/Models/IResponse';
import { IUser } from '../../../../../Domain/Models/IUser';
export async function GetById(id: number): Promise<IResponse<IUser>> {
  let response = await axios.get(`/api/usuario/${id}`);

  return response.data;
}
