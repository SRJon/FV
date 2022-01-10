export class EditPerfilWords {
  private _title: string = '';
  private _indexTitle: number = 0;
  private _titleList: string[] = ['CRIAR PERFIL', 'EDITAR PERFIL'];
  private _idInput: string = 'Id';
  private _nomeInput: string = 'Nome';
  private _peR_CODInput: string = 'PER_COD';
  private _perfilTelaInput: string = 'Perfil Tela';
  private _usuarioInput: string = 'Usuário';

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
