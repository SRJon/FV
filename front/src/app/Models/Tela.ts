import { ITela } from '../Domain/Models/ITela';

export class Tela implements ITela {
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
  telaId: number;
  relateds: ITela[] = [];
  tela: ITela | null;

  constructor(
    id: number | undefined,
    nome: string,
    url: string,
    addUrl: string,
    target: string,
    nivel: boolean,
    ordem: number,
    modulo: string,
    sd: boolean,
    imagemSd: string,
    iconClass: string,
    telaId: number,
    relateds: ITela[] = [],
    tela: ITela | null = null
  ) {
    this.id = id;
    this.nome = nome;
    this.url = url;
    this.addUrl = addUrl;
    this.target = target;
    this.nivel = nivel;
    this.ordem = ordem;
    this.modulo = modulo;
    this.sd = sd;
    this.imagemSd = imagemSd;
    this.iconClass = iconClass;
    this.telaId = telaId;
    this.relateds = relateds;
    this.tela = tela;
  }

  static fromJson(jsonData: ITela): Tela {
    return new Tela(
      jsonData.id,
      jsonData.nome,
      jsonData.url,
      jsonData.addUrl,
      jsonData.target,
      jsonData.nivel,
      jsonData.ordem,
      jsonData.modulo,
      jsonData.sd,
      jsonData.imagemSd,
      jsonData.iconClass,
      jsonData.telaId,
      [],
      jsonData.tela
    );
  }

  static toJson(tela: Tela): ITela {
    return {
      id: tela.id,
      nome: tela.nome,
      url: tela.url,
      addUrl: tela.addUrl,
      target: tela.target,
      nivel: tela.nivel,
      ordem: tela.ordem,
      modulo: tela.modulo,
      sd: tela.sd,
      imagemSd: tela.imagemSd,
      iconClass: tela.iconClass,
      telaId: tela.telaId,
      relateds: tela.relateds,
      tela: tela.tela,
    };
  }
}
