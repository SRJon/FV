import axios from 'axios';
import { IUser } from 'src/app/Domain/Models/IUser';
import { IResponse } from '../../../../../Domain/Models/IResponse';

export async function GetAll(
  page: number,
  limit: number
): Promise<IResponse<IUser[]>> {
  let result = await axios.get(`/api/Usuario?page=${page}&limit=${limit}`);
  return result.data;
}
