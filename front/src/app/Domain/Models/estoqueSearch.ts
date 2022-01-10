export class EstoqueSearch {
  produto: number;
  codgrupoprod: number;
  descrprod: string;
  compldesc: string;

  constructor() {
    this.produto = -1;
    this.codgrupoprod = -1;
    this.descrprod = '';
    this.compldesc = '';
  }

  static getInstance() {
    return new EstoqueSearch();
  }
}
