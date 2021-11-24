export class UsuarioEditWords {
  idInput: string = 'id';
  nomeInput: string = 'nome';
  ativoInput: string = 'ativo';
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
