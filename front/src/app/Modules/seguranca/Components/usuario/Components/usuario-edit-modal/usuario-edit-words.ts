export class UsuarioEditWords {
  idInput: string = 'id';
  nomeInput: string = 'nome';
  ativoInput: string = 'ativo';
  loginInput: string = 'login';
  senhaInput: string = 'senha';
  emailInput: string = 'email';
  alterPassNextLogonInput: string = 'ALTERAR SENHA PRÓX. LOGIN';

  perfilInput: string = 'perfil';
  vendedorInput: string = 'Vendedor';
  sankyaUserId: string = 'USUÁRIO';
  sakyaGrupId: string = 'GRUPO';
  limitInput: string = 'LIMITE ACESSO';
  lastUpdatePasswordInput: string = 'Última alteração de senha';

  private _titles: string[];
  private _index: number = 0;

  constructor() {
    this._titles = ['Atualizando Usuario', 'Cadastrando Usuario'];
  }
  get title(): string {
    return this._titles[this._index];
  }

  set index(value: number) {
    this._index = value;
  }
}
