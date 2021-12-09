import { IEmpresa } from './IEmpresa';
export interface IUsuarioEmp {
  id: number;
  usuarioId: number;
  empresaId: number;
  empresa?: IEmpresa[];
}
