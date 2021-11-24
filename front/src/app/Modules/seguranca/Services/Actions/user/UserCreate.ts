import axios from 'axios';
import { IResponse } from 'src/app/Domain/Models/IResponse';
import { IUser } from 'src/app/Domain/Models/IUser';

export async function create(user: IUser): Promise<IResponse<boolean>> {
  var result = await axios.post(`/user/create`, user);
  return result.data;
}
