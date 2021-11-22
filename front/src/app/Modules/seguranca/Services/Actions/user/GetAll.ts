import axios from 'axios';

export async function GetAll(page: number, limit: number) {
  let result = await axios.get(`/api/Usuario?page=${page}&limit=${limit}`);
  console.log(result);
}
