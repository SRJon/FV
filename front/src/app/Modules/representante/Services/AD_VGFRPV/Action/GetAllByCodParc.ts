import axios from 'axios';
export async function GetAllByCodParc(
  codparc: Number,
  page: number = 1,
  limit: number = 10
) {
  let respose = await axios.get(
    `/api/Pedido/GetAllByCodParc?page=${page}&limit=${limit}&codParc=${codparc}`
  );

  return respose.data;
}
