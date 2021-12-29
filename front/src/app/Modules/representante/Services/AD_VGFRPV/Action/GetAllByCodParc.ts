import axios from 'axios';
export async function GetAllByCodParc(codparc: Number) {
  let respose = await axios.get(
    `/api/Pedido/GetAllByCodParc?page=${1}&limit=${10}&codParc=${codparc}`
  );

  return respose.data;
}
