using back.domain.entities;
using System;

namespace back.data.entities.AD_ESTPROGPROD
{
    public class AD_ESTPROGPROD : IAD_ESTPROGPROD
    {
        public short CodEmp { get; set; }
        public int CodLocal { get; set; }
        public int CodProdgr1 { get; set; }
        public int CodProdgr2 { get; set; }
        public int CodProd { get; set; }
        public int? CodCor { get; set; }
        public string CodCor2 { get; set; }
        public string AD_CodCorant { get; set; }
        public int? CodGrupoCor { get; set; }
        public string CodHex { get; set; }
        public string CodPantone { get; set; }
        public int CodProj { get; set; }
        public string Controle { get; set; }
        public double? Disponivel { get; set; }
        public string Produto { get; set; }
        public string Sequencia { get; set; }
        public string Bloqueado { get; set; }
        public string Ad_Ld { get; set; }
        public string CodVol { get; set; }
        public DateTime? DtPrevisaoCheg { get; set; }
        public string DescrProd { get; set; }
        public int CodGrupoProd { get; set; }
    }
}
