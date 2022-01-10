import { IEmpresa } from './IEmpresa';
import { ITGFcab } from './ITGFcab';

export interface IadDevsolicitacao {
  nusoldev: number;
  codParc: number;
  dtNeg: Date;
  tipoDev: string;
  codEmp: number;
  nuNota: number;
  desconto: string;
  percDesc: number;
  comissao: number;
  IEmpresa: IEmpresa;
  ITGFcab: ITGFcab;
}
