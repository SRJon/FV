import axios from 'axios';
import { IResponse } from 'src/app/Domain/Models/IResponse';
import { IEmpresa } from 'src/app/Domain/Models/IEmpresa';

export async function CompanyCreate(
    company: IEmpresa
): Promise<IResponse<boolean>> {
    const response = await axios.post('/api/Empresa/Create', company);
    return response.data;
}
