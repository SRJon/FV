import axios from 'axios';
import { IResponse } from 'src/app/Domain/Models/IResponse';
import { IPerfil } from 'src/app/Domain/Models/IPerfil';

export async function PerfilCreate(
    Perfil: IPerfil
): Promise<IResponse<boolean>> {
    const response = await axios.post('/api/Perfil/Create', Perfil);
    return response.data;
}
