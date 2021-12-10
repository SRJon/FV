import axios from 'axios';
import { IDiretorio } from 'src/app/Domain/Models/IDiretorio';
import { IResponse } from 'src/app/Domain/Models/IResponse';

export async function DirectoryCreate(
  parameter: IDiretorio
): Promise<IResponse<boolean>> {
  let response = await axios.post('/api/Diretorio/Create', parameter);
  return response.data;
}
