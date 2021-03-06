import axios from 'axios';
import { IAvgfrpvgetall } from 'src/app/Domain/Models/IAvgfrpvgetall';
import { IResponse } from 'src/app/Domain/Models/IResponse';

export async function GetByParc(
  codVend: number
): Promise<IResponse<IAvgfrpvgetall>> {
  let result = await axios.get(
    `/api/TGFPAR/GetClienteBasicoById?id=${codVend}`
  );

  return result.data;
}
