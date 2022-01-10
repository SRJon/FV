export class EditPerfilWords {
  private _title = '';
  private _indexTitle = 0;
  private _titleList: string[] = ['CRIAR PERFIL', 'EDITAR PERFIL'];
  private _idInput = 'Id';
  private _nomeInput = 'Nome';
  private _peR_CODInput = 'PER_COD';
  private _perfilTelaInput = 'Perfil Tela';
  private _usuarioInput = 'Usuário';

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

  public get peR_CODInput(): string {
    return this._peR_CODInput;
  }

  public get perfilTelaInput(): string {
    return this._perfilTelaInput;
  }

  public get usuarioInput(): string {
    return this._usuarioInput;
  }

  public set indexTitle(value: number) {
    this._title = this._titleList[value];
    this._indexTitle = value;
  }

  public set titleList(value: string[]) {
    this._titleList = value;
  }

  static getInstance(): EditPerfilWords {
    return new EditPerfilWords();
  }
}
