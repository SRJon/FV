import axios from 'axios';
import { INotaFinanceiro } from 'src/app/Domain/Models/NotaFinanceiro';
import { IResponse } from '../../../../../Domain/Models/IResponse';

export async function GetAllFinanceiro(
  codParc: number,
  page: number,
  limit: number
): Promise<IResponse<INotaFinanceiro[]>> {
  let response = await axios.get(
    `/api/TGFFIN/GetAllFinanceiro?codParc=${codParc}&page=${page}&limit=${limit}`
  );

  return response.data;
}
