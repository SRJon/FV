import axios from 'axios';
import { IResponse } from 'src/app/Domain/Models/IResponse';
import { ITela } from '../../../../Domain/Models/ITela';

export async function ScreenCreate(screen: ITela): Promise<IResponse<boolean>> {
  let response = await axios.post('/api/Tela/Create', screen);
  return response.data;
}
