import { IEmpresa } from './IEmpresa';
import { ITgftpv } from './ITgftpv';

export interface INotaFiscal {
  nunota: number;
  numnota: number;
  dtfatur: Date;
  vlrnota: number;
  ad_perccom: number;
  codparc: number;
  codemp: number;
  empresa: IEmpresa;
  codtipvenda: number;
  dtalter: Date;
  tgftpv: ITgftpv;
  tipmov: string;
  statusnota: string;
  statusnfe: string;
}
