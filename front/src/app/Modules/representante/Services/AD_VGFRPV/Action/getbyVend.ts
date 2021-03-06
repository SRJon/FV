import axios from 'axios';
import { IAvgfrpvgetall } from 'src/app/Domain/Models/IAvgfrpvgetall';
import { IResponse } from 'src/app/Domain/Models/IResponse';

export async function GetByVend(
  codVend: number
): Promise<IResponse<IAvgfrpvgetall>> {
  let result = await axios.get(`/api/AD_VGFRPV/GetByIdVend?codVend=${codVend}`);

  return result.data;
}
