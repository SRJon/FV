using back.domain.entities;

namespace back.data.entities.View_AD_ESTPRODCOR
{
    public class AD_ESTPRODCOR : IAD_ESTPRODCOR
    {
        public short CodEmp { get; set; }
        public int CodLocal { get; set; }
        public int CodProdgr1 { get; set; }
        public int CodProdgr2 { get; set; }
        public int CodProd { get; set; }
        public int? CodCor { get; set; }
        public string CodCor2 { get; set; }
        public string Ad_CodCorant { get; set; }
        public int? CodGrupoCor { get; set; }
        public string CodHex { get; set; }
        public string CodPantone { get; set; }
        public double? Disponivel { get; set; }
        public string Produto { get; set; }
        public string Sequencia { get; set; }
        public string Ad_Ld { get; set; }
        public string CodVol { get; set; }
    }
}
