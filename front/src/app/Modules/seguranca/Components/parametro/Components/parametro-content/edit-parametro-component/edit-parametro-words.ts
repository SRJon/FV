export class EditParametroWords {
  private _title = '';
  private _indexTitle = 0;
  private _titleList: string[] = ['CRIAR PARÂMETRO', 'EDITAR PARÂMETRO'];
  private _idInput = 'Id';
  private _nomeInput = 'Nome';
  private _valorInput = 'Valor';
  private _descricaoInput = 'Descrição';

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

  public get valorInput(): string {
    return this._valorInput;
  }

  public get descricaoInput(): string {
    return this._descricaoInput;
  }

  public set indexTitle(value: number) {
    this._title = this._titleList[value];
    this._indexTitle = value;
  }

  public set titleList(value: string[]) {
    this._titleList = value;
  }

  static getInstance(): EditParametroWords {
    return new EditParametroWords();
  }
}
