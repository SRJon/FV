import axios from 'axios';
import { INotaFiscal } from 'src/app/Domain/Models/INotaFiscal';
import { IResponse } from 'src/app/Domain/Models/IResponse';

export async function GetAllNF(
  codParc: number,
  page: number,
  limit: number
): Promise<IResponse<INotaFiscal[]>> {
  let response = await axios.get(
    `/api/TGFCAB/GetAllACABNF?codParc=${codParc}&page=${page}&limit=${limit}`
  );
  console.log(response.data);
  return response.data;
}
