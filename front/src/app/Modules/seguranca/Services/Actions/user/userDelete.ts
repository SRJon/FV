import axios from 'axios';
import { IResponse } from '../../../../../Domain/Models/IResponse';
export async function Userdelete(id: number): Promise<IResponse<boolean>> {
  let response = await axios.post(
    `http://localhost:5000/api/Usuario/Delete?id=${id}`
  );
  return response.data;
}
