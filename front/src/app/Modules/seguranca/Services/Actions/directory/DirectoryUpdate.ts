import axios from 'axios';
import { IDiretorio } from 'src/app/Domain/Models/IDiretorio';
import { IResponse } from 'src/app/Domain/Models/IResponse';

export async function DirectoryUpdate(
    parameter: IDiretorio
): Promise<IResponse<boolean>> {
    const response = await axios.post('/api/Diretorio/Update', parameter);
    return response.data;
}
