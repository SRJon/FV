import { IEmpresa } from './IEmpresa';
import { IPedidoItem } from './IPedidoItem';
import { ITcsprj } from './ITcsprj';
import { ITgfpar } from './ITgfpar';
import { ITgftpv } from './ITgftpv';
import { IUsuario } from './IUsuario';

export interface Pedido {
  id: number;
  frete: string;
  clienteCod: number;
  comprador: string;
  observacao: string;
  remessa: boolean;
  clienteRemCod: number;
  condPagCodTipVenda: number;
  condPagDhAlter: Date;
  status: string;
  dtCriacao: Date;
  dtEnvio: Date;
  pedSankhyaNuNota: number;
  orcamento: boolean;
  usuarioId: number;
  empresaId: number;
  estoque: string;
  pilotagem: boolean;
  tipoPilotagem: number;
  projetoCod: number;
  vendedorPCod: number;
  regraCif: string;
  ligarAntes: string;
  redpTel: string;
  redpRazao: string;
  redpCnpj: string;
  redp: string;
  ld: string;
  mediaNeg: number;
  confirmado: string;
  msgConfirmado: string;
  cnpjNovoCliente: string;
  tipoFrete: string;
  contatoCod: number;
  contatoCodParc: number;
  redespachoCodRed: number;
  dtBaseFin: Date;
  dtFat: Date;
  ordemCompra: string;
  pedidoItemDtFat: boolean;
  pedidoItemOrdemComp: boolean;
  diasVenc: number;
  dtCartao: Date;
  empresa: IEmpresa;
  usuario: IUsuario;
  tgftpv: ITgftpv;
  tcsprj: ITcsprj;
  tgfpar: ITgfpar;
  pedidoItem: IPedidoItem[];
}
