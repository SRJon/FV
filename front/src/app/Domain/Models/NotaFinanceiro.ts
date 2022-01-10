import { IEmpresa } from './IEmpresa';
import { ITGFcab } from './ITGFcab';

export interface INotaFinanceiro {
  nufin: number;
  numnota: number;
  codemp: number;
  provisao: string;
  dtneg: Date;
  dtvenc: Date;
  dhbaixa: Date;
  vlrdesdob: number;
  desdobramento: string;
  recdesp: number;
  empresa: IEmpresa;
  nunota: number;
  tgfcab: ITGFcab;
}
