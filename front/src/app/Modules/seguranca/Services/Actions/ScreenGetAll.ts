import { ITela } from '../../../../Domain/Models/ITela';
import axios from 'axios';
import { IResponse } from 'src/app/Domain/Models/IResponse';

export async function GetAll(
  page: number = 1,
  limit: number = 1
): Promise<IResponse<ITela[]>> {
  try {
    let result = await axios.get(`/api/Tela?page=${page}&limit=${limit}`);

    return result.data;
  } catch (error) {
    throw error;
  }
}
