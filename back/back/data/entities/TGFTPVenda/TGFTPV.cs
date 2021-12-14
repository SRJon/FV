using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using back.domain.entities;

namespace back.data.entities.TGFTPVenda
{
    public class TGFTPV : ITGFTPV
    {
        [Key]
        [Column("CODTIPVENDA")]
        public short Codtipvenda { get; set; }
        [Key]
        [Column("DHALTER")]
        public DateTime Dhalter { get; set; }
        public string Descrtipvenda { get; set; }
        public string Subtipovenda { get; set; }
        public short? CodTab { get; set; }
        public string Ativo { get; set; }
        public decimal? Vendamin { get; set; }
        public decimal? Vendamax { get; set; }
        public decimal? TaxaJuro { get; set; }
        public string Tiptaxa { get; set; }
        public string Tipjuro { get; set; }
        public string Grupoautor { get; set; }
        public string Valprazocliente { get; set; }
        public short? Baseprazo { get; set; }
        public double? Comissao { get; set; }
        public string Fixavenc { get; set; }
        public string Emiteboleta { get; set; }
        public string Emitedupl { get; set; }
        public string Aprestransp { get; set; }
        public int? Codctactb_1 { get; set; }
        public int? Codctactb_2 { get; set; }
        public int? Nunota { get; set; }
        public string Baixa { get; set; }
        public decimal? DescMax { get; set; }
        public short? Prazomedmax { get; set; }
        public short? Prazomax { get; set; }
        public string Somaprazocliente { get; set; }
        public string Podeconsumidor { get; set; }
        public short? Codobspadrao { get; set; }
        public short? Codusu { get; set; }
        public int? Codformdescmax { get; set; }
        public int? Codformdescmaxitens { get; set; }
        public double? Lucromin { get; set; }
        public string Descprom { get; set; }
        public double? Percminentrada { get; set; }
        public short? Nroparcelas { get; set; }
        public short? Prazomaxpriparc { get; set; }
        public int? Codtcf { get; set; }
        public string Flex { get; set; }
        public double? MargemMin { get; set; }
        public string Modelopgto { get; set; }
        public double? TaxaJurSim { get; set; }
        public string TipoJurSim { get; set; }
        public double? PercDesagFlex { get; set; }
        public double? CompraMax { get; set; }
        public short? PrazoMin { get; set; }
        public string Editasimulacao { get; set; }
        public string Exptes { get; set; }
        public short? Expgrs { get; set; }
        public double? Txparcadm { get; set; }
        public string Integraeconect { get; set; }
        public int? FormarECbtoSocin { get; set; }
        public string Fastusa { get; set; }
        public string VencPrefixped { get; set; }
        public string Arredprimeiraparc { get; set; }
        public string Truncparcela { get; set; }
        public string Ad_Librepresentate { get; set; }
        public int? TimQtdParc { get; set; }
        public int? Ad_Codemp { get; set; }
        public string Ad_Tipo { get; set; }
    }
}