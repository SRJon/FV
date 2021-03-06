import axios from 'axios';
import { IResponse } from 'src/app/Domain/Models/IResponse';
import { IParametro } from 'src/app/Domain/Models/IParametro';

export async function ParameterCreate(
  parameter: IParametro
): Promise<IResponse<boolean>> {
  let response = await axios.post('/api/Parametro/Create', parameter);
  return response.data;
}
