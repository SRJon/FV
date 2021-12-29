using back.domain.entities;

namespace back.data.entities.AD_PANTONE_Cor
{
    public class AD_PANTONE : IAD_PANTONE
    {
        public int CodCor { get; set; }
        public string CodHex { get; set; }
        public int? Pagina { get; set; }
        public string CodCor2 { get; set; }
        public int? CodGrupoCor { get; set; }
        public string CodPantone { get; set; }
        public string NomeCor { get; set; }
        public string Estampado { get; set; }
    }
}
