import axios from 'axios';
import { IAD_ESTCODPROD } from './../../../../../Domain/Models/IAD_ESTCODPROD';
import { IResponse } from './../../../../../Domain/Models/IResponse';

export async function GetAdEstCodProd(
  page: number = 1,
  limit: number = 1,
  Produto: number = -1,
  CodGrupoProd: number = -1,
  DescrProd: string,
  ComplDesc: string
): Promise<IResponse<IAD_ESTCODPROD[]>> {
  try {
    let result = await axios.get(
      `/api/AD_ESTCODPROD?page=${page}&limit=${limit}&Produto=${Produto}&CodGrupoProd=${CodGrupoProd}&DescrProd=${DescrProd}&ComplDesc=${ComplDesc}`
    );
    return result.data;
  } catch (error) {
    throw error;
  }
}
