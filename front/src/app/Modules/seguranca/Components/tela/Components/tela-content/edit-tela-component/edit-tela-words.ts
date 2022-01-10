export class EditTelaWords {
  private _title = '';
  private _indexTitle = 0;
  private _titleList: string[] = ['CRIAR TELA', 'EDITAR TELA'];
  private _idInput = 'Id';
  private _nomeInput = 'Nome';

  private _urlInput = 'Url';
  private _targetInput = 'Target';
  private _ordemInput = 'Ordem';
  private _moduloInput = 'Modulo';
  private _nivelInput = 'Nivel';
  private _telaNivelInput = 'Tela Nivel';

  public get telaNivelInput(): string {
    return this._telaNivelInput;
  }

  public get nivelInput(): string {
    return this._nivelInput;
  }

  public get moduloInput(): string {
    return this._moduloInput;
  }

  public get ordemInput(): string {
    return this._ordemInput;
  }

  public get targetInput(): string {
    return this._targetInput;
  }

  public get urlInput(): string {
    return this._urlInput;
  }
  public get nomeInput(): string {
    return this._nomeInput;
  }
  public get idInput(): string {
    return this._idInput;
  }

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

  public set indexTitle(value: number) {
    this._title = this._titleList[value];
    this._indexTitle = value;
  }

  public set titleList(value: string[]) {
    this._titleList = value;
  }

  static getInstance(): EditTelaWords {
    return new EditTelaWords();
  }
}
