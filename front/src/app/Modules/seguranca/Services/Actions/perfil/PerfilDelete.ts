import axios from 'axios';
import { IResponse } from 'src/app/Domain/Models/IResponse';

export async function PerfilDelete(id: number): Promise<IResponse<boolean>> {
  return await (
    await axios.post(`/api/Perfil/Delete?id=${id}`)
  ).data;
}
