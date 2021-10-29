export class Tela {
  TelaId:        number | undefined;
  TelaNome:      string;
  TelaUrl:       string;
  TelaAddUrl:    string;
  TelaTarget:    string;
  TelaNivel:     boolean;
  TelaOrdem:     number;
  TelaModulo:    string;
  TelaSD:        boolean;
  TelaImagemSD:  string;
  TelaIconClass: string;

  constructor(
    TelaId:        number | undefined,
    TelaNome:      string,
    TelaUrl:       string,
    TelaAddUrl:    string,
    TelaTarget:    string,
    TelaNivel:     boolean,
    TelaOrdem:     number,
    TelaModulo:    string,
    TelaSD:        boolean,
    TelaImagemSD:  string,
    TelaIconClass: string
) {
    this.TelaId = TelaId
    this.TelaNome = TelaNome
    this.TelaUrl = TelaUrl
    this.TelaAddUrl = TelaAddUrl
    this.TelaTarget = TelaTarget
    this.TelaNivel = TelaNivel
    this.TelaOrdem = TelaOrdem
    this.TelaModulo = TelaModulo
    this.TelaSD = TelaSD
    this.TelaImagemSD = TelaImagemSD
    this.TelaIconClass = TelaIconClass
  }

}
