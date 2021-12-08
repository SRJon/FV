export class EditEmpresaWords {
  private _title: string = '';
  private _indexTitle: number = 0;
  private _titleList: string[] = ['Create', 'Edit'];
  private _idInput: string = 'Id';
  private _nomeInput: string = 'Nome';
  private _vlrMinFreteInput: string = 'Valor de Frete Mínimo';
  private _vlrMinPedidoInput: string = 'Valor de Pedido Mínimo';
  private _codEmpInput: string = 'Código da Empresa no Sankhya';

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

  public get vlrMinFreteInput(): string {
    return this._vlrMinFreteInput;
  }

  public get vlrMinPedidoInput(): string {
    return this._vlrMinPedidoInput;
  }

  public get codEmpInput(): string {
    return this._codEmpInput;
  }

  public set indexTitle(value: number) {
    this._title = this._titleList[value];
    this._indexTitle = value;
  }

  public set titleList(value: string[]) {
    this._titleList = value;
  }

  static getInstance(): EditEmpresaWords {
    return new EditEmpresaWords();
  }
}
