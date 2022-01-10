import axios from 'axios';
import { IResponse } from 'src/app/Domain/Models/IResponse';
import { IUser } from 'src/app/Domain/Models/IUser';

export async function UserCreate(user: IUser): Promise<IResponse<boolean>> {
  let response = await axios.post('/api/Usuario/Create', user);
  return response.data;
}
