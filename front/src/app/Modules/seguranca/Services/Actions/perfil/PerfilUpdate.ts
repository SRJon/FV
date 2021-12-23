import axios from 'axios';
import { IResponse } from 'src/app/Domain/Models/IResponse';
import { IPerfil } from 'src/app/Domain/Models/IPerfil';

export async function PerfilUpdate(
  Perfil: IPerfil
): Promise<IResponse<boolean>> {
  let response = await axios.post('/api/Perfil/Update', Perfil);
  return response.data;
}
