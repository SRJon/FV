import { IEmpresa } from './IEmpresa';
import { ITGFcab } from './ITGFcab';

export interface ISolicitacaoDevolucao {
  nusoldev: number;
  codParc: number;
  dtNeg: Date;
  tipoDev: string;
  codEmp: number;
  nuNota: number;
  desconto: null | string;
  percDesc: number | null;
  comissao: number | null;
  empresa: IEmpresa;
  tgfcab: ITGFcab;
}
