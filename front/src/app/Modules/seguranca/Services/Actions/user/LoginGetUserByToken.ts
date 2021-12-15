import { IUser } from 'src/app/Domain/Models/IUser';
import axios from 'axios';
import { IResponse } from '../../../../../Domain/Models/IResponse';

export async function LoginGetUserByToken(
  token: string
): Promise<IResponse<IUser | undefined>> {
  try {
    let result = await axios.post('/getUserByToken', { token });
    return result.data;
  } catch (error) {
    return { data: undefined } as IResponse<IUser | undefined>;
  }
}
