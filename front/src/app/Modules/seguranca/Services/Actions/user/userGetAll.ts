import axios from 'axios';
import { IUser } from 'src/app/Domain/Models/IUser';
import { IResponse } from '../../../../../Domain/Models/IResponse';

export async function UserGetAll(
    page = 1,
    limit = 1
): Promise<IResponse<IUser[]>> {
    try {
        const result = await axios.get(`/api/Usuario?page=${page}&limit=${limit}`);

        return result.data;
    } catch (error) {
        throw error;
    }
}
