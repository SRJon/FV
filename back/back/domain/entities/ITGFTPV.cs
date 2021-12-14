using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace back.domain.entities
{
    public interface ITGFTPV
    {
        public short Codtipvenda { get; set; }
        public DateTime Dhalter { get; set; }
        public string Descrtipvenda { get; set; }
        public string Subtipovenda { get; set; }
        public Nullable<short> CodTab { get; set; }
        public string Ativo { get; set; }
        public Nullable<decimal> Vendamin { get; set; }
        public Nullable<decimal> Vendamax { get; set; }
        public Nullable<decimal> TaxaJuro { get; set; }
        public string Tiptaxa { get; set; }
        public string Tipjuro { get; set; }
        public string Grupoautor { get; set; }
        public string Valprazocliente { get; set; }
        public Nullable<short> Baseprazo { get; set; }
        public Nullable<double> Comissao { get; set; }
        public string Fixavenc { get; set; }
        public string Emiteboleta { get; set; }
        public string Emitedupl { get; set; }
        public string Aprestransp { get; set; }
        public Nullable<int> Codctactb_1 { get; set; }
        public Nullable<int> Codctactb_2 { get; set; }
        public Nullable<int> Nunota { get; set; }
        public string Baixa { get; set; }
        public Nullable<decimal> DescMax { get; set; }
        public Nullable<short> Prazomedmax { get; set; }
        public Nullable<short> Prazomax { get; set; }
        public string Somaprazocliente { get; set; }
        public string Podeconsumidor { get; set; }
        public Nullable<short> Codobspadrao { get; set; }
        public Nullable<short> Codusu { get; set; }
        public Nullable<int> Codformdescmax { get; set; }
        public Nullable<int> Codformdescmaxitens { get; set; }
        public Nullable<double> Lucromin { get; set; }
        public string Descprom { get; set; }
        public Nullable<double> Percminentrada { get; set; }
        public Nullable<short> Nroparcelas { get; set; }
        public Nullable<short> Prazomaxpriparc { get; set; }
        public Nullable<int> Codtcf { get; set; }
        public string Flex { get; set; }
        public Nullable<double> MargemMin { get; set; }
        public string Modelopgto { get; set; }
        public Nullable<double> TaxaJurSim { get; set; }
        public string TipoJurSim { get; set; }
        public Nullable<double> PercDesagFlex { get; set; }
        public Nullable<double> CompraMax { get; set; }
        public Nullable<short> PrazoMin { get; set; }
        public string Editasimulacao { get; set; }
        public string Exptes { get; set; }
        public Nullable<short> Expgrs { get; set; }
        public Nullable<double> Txparcadm { get; set; }
        public string Integraeconect { get; set; }
        public Nullable<int> FormarECbtoSocin { get; set; }
        public string Fastusa { get; set; }
        public string VencPrefixped { get; set; }
        public string Arredprimeiraparc { get; set; }
        public string Truncparcela { get; set; }

        public string Ad_Librepresentate { get; set; }
        public Nullable<int> TimQtdParc { get; set; }
        public Nullable<int> Ad_Codemp { get; set; }
        public string Ad_Tipo { get; set; }
    }
}