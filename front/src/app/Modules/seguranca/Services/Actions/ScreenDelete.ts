import axios from 'axios';
import { IResponse } from '../../../../Domain/Models/IResponse';

export async function Delete(id: number): Promise<IResponse<boolean>> {
  return await (
    await axios.post(`/api/Tela/Delete?id${id}`)
  ).data;
}
