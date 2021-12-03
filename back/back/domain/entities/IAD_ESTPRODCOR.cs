using System;

namespace back.domain.entities
{
    public interface IAD_ESTPRODCOR
    {
        public short CodEmp { get; set; }
        public int CodLocal { get; set; }
        public int CodProdgr1 { get; set; }
        public int CodProdgr2 { get; set; }
        public int CodProd { get; set; }
        public Nullable<int> CodCor { get; set; }
        public string CodCor2 { get; set; }
        public string Ad_CodCorant { get; set; }
        public Nullable<int> CodGrupoCor { get; set; }
        public string CodHex { get; set; }
        public string CodPantone { get; set; }
        public Nullable<double> Disponivel { get; set; }
        public string Produto { get; set; }
        public string Sequencia { get; set; }
        public string Ad_Ld { get; set; }
        public string CodVol { get; set; }

    }
}
