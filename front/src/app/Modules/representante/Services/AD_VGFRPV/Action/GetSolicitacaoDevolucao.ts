import axios from 'axios';
import { IResponse } from 'src/app/Domain/Models/IResponse';
import { ISolicitacaoDevolucao } from 'src/app/Domain/Models/ISolicitacaoDevolucao';

export async function GetSolicitacaoDevolucao(
  codParc: number,
  page: number,
  limit: number
): Promise<IResponse<ISolicitacaoDevolucao[]>> {
  const response = await axios.get(
    `/api/AD_DEVSOLICITACAO/GetAllDevolucao?codParc=${codParc}&page=${page}&limit=${limit}`
  );
  return response.data;
}
