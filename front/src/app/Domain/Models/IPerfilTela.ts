import { ITela } from './ITela';

export interface IPerfilTela {
  id: number;
  perfilId: number;
  telaId: number;
  ins: boolean;
  dsp: boolean;
  upd: boolean;
  dlt: boolean;
  telas: ITela;
}
