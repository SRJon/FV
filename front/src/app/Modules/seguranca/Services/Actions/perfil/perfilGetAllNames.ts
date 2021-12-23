import axios from 'axios';
import { IResponse } from '../../../../../Domain/Models/IResponse';
import { IPerfil } from '../../../../../Domain/Models/IPerfil';
export async function PerfilGetAllNames(
  page: number,
  limit: number
): Promise<IResponse<IPerfil[]>> {
  var response = await axios.get(
    `/api/Perfil/GetAllNames?page=${page}&limit=${limit}`
  );
  return response.data;
}
