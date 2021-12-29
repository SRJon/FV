import { ITGFRGV } from './../../../../../Domain/Models/ITGFRGV';
import axios from 'axios';
import { IResponse } from 'src/app/Domain/Models/IResponse';

export async function GetCodGrupoProd(
  CODVEND: number
): Promise<IResponse<ITGFRGV[]>> {
  try {
    let result = await axios.get(`/api/TGFRGV/CodVend/${CODVEND}`);
    return result.data;
  } catch (error) {
    throw error;
  }
}
