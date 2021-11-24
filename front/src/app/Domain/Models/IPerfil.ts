import { IPerfilTela } from './IPerfilTela';
import { IUser } from './IUser';
export interface IPerfil {
  id: number;
  nome: string;
  peR_COD: number;
  perfilTela?: IPerfilTela[];
  usuario?: IUser[];
}
