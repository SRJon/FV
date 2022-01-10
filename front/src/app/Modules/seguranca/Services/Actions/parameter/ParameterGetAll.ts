import axios from 'axios';
import { IResponse } from 'src/app/Domain/Models/IResponse';
import { IParametro } from 'src/app/Domain/Models/IParametro';

export async function GetAll(
  page = 1,
  limit = 1
): Promise<IResponse<IParametro[]>> {
  try {
    const result = await axios.get(
      `/api/Parametro?page=${page}&limit=${limit}`
    );

    return result.data;
  } catch (error) {
    throw error;
  }
}
