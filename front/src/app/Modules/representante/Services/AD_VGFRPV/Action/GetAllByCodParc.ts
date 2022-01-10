import axios from 'axios';
export async function GetAllByCodParc(codparc: number, page = 1, limit = 10) {
  const respose = await axios.get(
    `/api/Pedido/GetAllByCodParc?page=${page}&limit=${limit}&codParc=${codparc}`
  );

  return respose.data;
}
