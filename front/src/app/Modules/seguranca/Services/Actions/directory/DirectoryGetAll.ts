import axios from 'axios';
import { IDiretorio } from 'src/app/Domain/Models/IDiretorio';
import { IResponse } from 'src/app/Domain/Models/IResponse';

export async function GetAll(
  page: number = 1,
  limit: number = 1
): Promise<IResponse<IDiretorio[]>> {
  try {
    let result = await axios.get(`/api/Diretorio?page=${page}&limit=${limit}`);

    return result.data;
  } catch (error) {
    throw error;
  }
}
