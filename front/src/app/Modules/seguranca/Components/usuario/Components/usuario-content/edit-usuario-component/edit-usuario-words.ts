export class EditUsuarioWords {
  private _title = '';
  private _indexTitle = 0;
  private _titleList: string[] = ['CRIAR USUARIO', 'EDITAR USUARIO'];
  private _idInput = 'Id';
  private _nomeInput = 'Nome';
  private _emailInput = 'Email';
  private _ativoInput = 'Ativo';
  private _loginInput = 'Login';
  private _senhaInput = 'Senha';
  private _perfilIdInput = 'Perfil';
  private _vendedorUCodInput = 'Código do Vendedor';
  private _altSenhaInput = 'Alteração da Senha';
  private _alterPassNextLogonInput = 'Alterar Senha Próx. Login';
  private _lastUpdatePasswordInput = 'Última alteração de senha';
  private _dtUltAltSenhaInput = 'Última aleração de Senha';
  private _perfilInput = 'Perfil';

  public get title(): string {
    this._title = this._titleList[this._indexTitle];
    return this._title;
  }

  public get indexTitle(): number {
    return this._indexTitle;
  }

  public get titleList(): string[] {
    return this._titleList;
  }

  public get idInput(): string {
    return this._idInput;
  }

  public get nomeInput(): string {
    return this._nomeInput;
  }

  public get emailInput(): string {
    return this._emailInput;
  }

  public get ativoInput(): string {
    return this._ativoInput;
  }

  public get loginInput(): string {
    return this._loginInput;
  }

  public get senhaInput(): string {
    return this._senhaInput;
  }

  public get perfilIdInput(): string {
    return this._perfilIdInput;
  }

  public get vendedorUCodInput(): string {
    return this._vendedorUCodInput;
  }

  public get altSenhaInput(): string {
    return this._altSenhaInput;
  }

  public get dtUltAltSenhaInput(): string {
    return this._dtUltAltSenhaInput;
  }

  public get perfilInput(): string {
    return this._perfilInput;
  }

  public get alterPassNextLogonInput(): string {
    return this._alterPassNextLogonInput;
  }

  public get lastUpdatePasswordInput(): string {
    return this._lastUpdatePasswordInput;
  }

  public set indexTitle(value: number) {
    this._title = this._titleList[value];
    this._indexTitle = value;
  }

  public set titleList(value: string[]) {
    this._titleList = value;
  }

  static getInstance(): EditUsuarioWords {
    return new EditUsuarioWords();
  }
}
