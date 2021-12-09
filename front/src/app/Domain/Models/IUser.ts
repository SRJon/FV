import { IUsuarioEmp } from './IUsuarioEmp';
import { IPerfil } from './IPerfil';

export interface IUser {
  id: number;
  login: string;
  senha?: string;
  nome: string;
  email: string;
  ativo: boolean;
  perfilId: number;
  vendedorUCod: number;
  altSenha: boolean;
  dtUltAltSenha: Date;
  loginSnk: string;
  sgtsiusU_USU_COD?: number;
  senhaFV?: string;
  perfil?: IPerfil;
  usuarioEmp?: IUsuarioEmp[];
}
