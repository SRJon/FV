import axios from 'axios';
import { IResponse } from 'src/app/Domain/Models/IResponse';
import { ITela } from 'src/app/Domain/Models/ITela';

export async function ScreenUpdate(screen: ITela): Promise<IResponse<boolean>> {
    const response = await axios.post('/api/Tela/Update', screen);
    return response.data;
}
