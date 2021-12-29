import axios from 'axios';
import { IResponse } from 'src/app/Domain/Models/IResponse';
import { IPerfil } from 'src/app/Domain/Models/IPerfil';

export async function PerfilGetAll(
  page: number = 1,
  limit: number = 1
): Promise<IResponse<IPerfil[]>> {
  try {
    let result = await axios.get(`/api/Perfil?page=${page}&limit=${limit}`);

    return result.data;
  } catch (error) {
    throw error;
  }
}
