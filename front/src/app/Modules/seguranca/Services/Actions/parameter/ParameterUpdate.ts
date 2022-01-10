import axios from 'axios';
import { IResponse } from 'src/app/Domain/Models/IResponse';
import { IParametro } from 'src/app/Domain/Models/IParametro';

export async function ParameterUpdate(
    parameter: IParametro
): Promise<IResponse<boolean>> {
    const response = await axios.post('/api/Parametro/Update', parameter);
    return response.data;
}
