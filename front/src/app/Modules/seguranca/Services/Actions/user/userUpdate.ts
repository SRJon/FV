import { IUser } from '../../../../../Domain/Models/IUser';
import { IResponse } from '../../../../../Domain/Models/IResponse';
import axios from 'axios';

export async function update(user: IUser): Promise<IResponse<boolean>> {
  let response = await axios.post('/api/Usuario/Update', user);

  return response.data;
}
