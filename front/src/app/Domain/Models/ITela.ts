/**
 * @class Tela
 * @implements {ITela}
 * @classdesc Classe que representa uma tela.
 * @constructor
 * @param {string} nome Nome da tela.
 * @param {string} descricao Descrição da tela.
 * @param {string} url Url da tela.
 * jao é um jogador de lol
 */
export interface ITela {
  id: number | undefined;
  nome: string;
  url: string;
  addUrl: string;
  target: string;
  nivel: boolean;
  ordem: number;
  modulo: string;
  sd: boolean;
  imagemSd: string;
  iconClass: string;
  telaId: number | undefined;
  relateds: ITela[];
  tela: ITela | null;
}
