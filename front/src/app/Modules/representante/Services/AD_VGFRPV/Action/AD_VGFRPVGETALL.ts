import axios from 'axios';
import { IAvgfrpvgetall } from 'src/app/Domain/Models/IAvgfrpvgetall';
import { IResponse } from '../../../../../Domain/Models/IResponse';

export async function AVGFRPVGETALL(
  page: number,
  limit: number
): Promise<IResponse<IAvgfrpvgetall[]>> {
  const result = await axios.get(`/api/AD_VGFRPV?page=${page}&limit${limit}`);

  return result.data;
}
