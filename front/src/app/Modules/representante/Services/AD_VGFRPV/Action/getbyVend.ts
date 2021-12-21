import axios from 'axios';

export function GetByVend(codVend: number) {
  axios.post('/api/AD_VGFRPV/GetByVend');
}
