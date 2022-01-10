import axios from 'axios';
import { IResponse } from '../../../../../Domain/Models/IResponse';

export async function UserDelete(id: number): Promise<IResponse<boolean>> {
  return await (
    await axios.post(`/api/Usuario/Delete?id=${id}`)
  ).data;
}
