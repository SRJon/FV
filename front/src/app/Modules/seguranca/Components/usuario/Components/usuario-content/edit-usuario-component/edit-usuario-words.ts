export class EditUsuarioWords {
  private _title: string = '';
  private _indexTitle: number = 0;
  private _titleList: string[] = ['CRIAR USUARIO', 'EDITAR USUARIO'];
  private _idInput: string = 'Id';
  private _nomeInput: string = 'Nome';
  private _emailInput: string = 'Email';
  private _ativoInput: string = 'Ativo';

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
