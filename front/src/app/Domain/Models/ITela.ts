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
