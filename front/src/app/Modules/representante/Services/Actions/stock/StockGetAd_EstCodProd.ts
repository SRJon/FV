import axios from 'axios';
import { IAD_ESTCODPROD } from './../../../../../Domain/Models/IAD_ESTCODPROD';
import { IResponse } from './../../../../../Domain/Models/IResponse';

export async function GetAdEstCodProd(
  page = 1,
  limit = 1,
  Produto = -1,
  CodGrupoProd = -1,
  DescrProd: string,
  ComplDesc: string
): Promise<IResponse<IAD_ESTCODPROD[]>> {
  try {
    const result = await axios.get(
      `/api/AD_ESTCODPROD?page=${page}&limit=${limit}&Produto=${Produto}&CodGrupoProd=${CodGrupoProd}&DescrProd=${DescrProd}&ComplDesc=${ComplDesc}`
    );
    return result.data;
  } catch (error) {
    throw error;
  }
}
