export class EditDiretorioWords {
  private _title = '';
  private _indexTitle = 0;
  private _titleList: string[] = ['CRIAR DIRETÓRIO', 'EDITAR DIRETÓRIO'];
  private _idInput = 'Id';
  private _tipoInput = 'Tipo';
  private _linkInput = 'Link';
  private _virtualInput = 'Virtual';

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

  public get tipoInput(): string {
    return this._tipoInput;
  }

  public get linkInput(): string {
    return this._linkInput;
  }

  public get virtualInput(): string {
    return this._virtualInput;
  }

  public set indexTitle(value: number) {
    this._title = this._titleList[value];
    this._indexTitle = value;
  }

  public set titleList(value: string[]) {
    this._titleList = value;
  }

  static getInstance(): EditDiretorioWords {
    return new EditDiretorioWords();
  }
}
