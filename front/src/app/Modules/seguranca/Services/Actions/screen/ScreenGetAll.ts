import axios from 'axios';
import { IResponse } from 'src/app/Domain/Models/IResponse';
import { ITela } from 'src/app/Domain/Models/ITela';

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
