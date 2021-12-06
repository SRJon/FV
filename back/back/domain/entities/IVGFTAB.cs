using System;

namespace back.domain.entities
{
    public interface IVGFTAB
    {
        public short CodTab { get; set; }
        public string Obs { get; set; }
        public string NomeTab { get; set; }
        public short DecVenda { get; set; }
        public int CodTipParc { get; set; }
        public Nullable<short> CodTabFlex { get; set; }
        public int CodReg { get; set; }
        public short CodMoeda { get; set; }
        public string Ativo { get; set; }
        public Nullable<double> Percentual { get; set; }
        public int NuTab { get; set; }
        public string Formula { get; set; }
        public DateTime DtVigor { get; set; }
        public DateTime DtAlter { get; set; }
        public Nullable<short> CodTabOrig { get; set; }
        public string Ad_Filtrar_Vendedor { get; set; }

    }
}
