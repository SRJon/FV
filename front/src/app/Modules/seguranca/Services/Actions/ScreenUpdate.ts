import axios from 'axios';
import { IResponse } from 'src/app/Domain/Models/IResponse';
import { ITela } from '../../../../Domain/Models/ITela';

export async function ScreenUpdate(screen: ITela): Promise<IResponse<boolean>> {
  let response = await axios.post('/api/Tela/Update', screen);
  console.log(response);
  return response.data;
}
