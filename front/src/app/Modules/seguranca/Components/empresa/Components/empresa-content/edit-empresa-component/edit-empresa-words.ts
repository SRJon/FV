export class EditEmpresaWords {
    private _title = '';
    private _indexTitle = 0;
    private _titleList: string[] = ['CRIAR EMPRESA', 'EDITAR EMPRESA'];
    private _idInput = 'Id';
    private _nomeInput = 'Nome';
    private _vlrMinFreteInput = 'Valor de Frete Mínimo';
    private _vlrMinPedidoInput = 'Valor de Pedido Mínimo';
    private _codEmpInput = 'Código da Empresa no Sankhya';

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
