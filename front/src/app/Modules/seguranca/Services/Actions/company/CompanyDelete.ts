import axios from 'axios';
import { IResponse } from 'src/app/Domain/Models/IResponse';

export async function Delete(id: number): Promise<IResponse<boolean>> {
  return await (
    await axios.post(`/api/Empresa/Delete?id=${id}`)
  ).data;
}
