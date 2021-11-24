export interface IUser {
  id: number;
  login: string;
  senha?: string;
  nome: string;
  email: string;
  ativo: boolean;
  perfilId: number;
  vendedorUCod: number;
  altSenha: null;
  dtUltAltSenha: Date;
  loginSnk: null;
  sgtsiusU_USU_COD?: null;
  senhaFV?: string;
  perfil?: Perfil;
}

export interface Perfil {
  id: number;
  nome: string;
  peR_COD: number;
}
