import axios from 'axios';
import { IResponse } from 'src/app/Domain/Models/IResponse';
import { IEmpresa } from 'src/app/Domain/Models/IEmpresa';

export async function GetAll(
  page: number = 1,
  limit: number = 1
): Promise<IResponse<IEmpresa[]>> {
  try {
    let result = await axios.get(`/api/Empresa?page=${page}&limit=${limit}`);

    return result.data;
  } catch (error) {
    throw error;
  }
}
