using System; 

namespace back.domain.entities
{
    public interface IAD_GERAL_PV
    {
        public int Nunota { get; set; }
        public string Vendedor { get; set; }
        public string  Parceiro { get; set; }
        public string ParcRemessa { get; set; }
        public string Redespacho { get; set; }
        public string TipOper { get; set; }
        public string TipoNeg { get; set; }
        public int CodProj { get; set; }
    }
}