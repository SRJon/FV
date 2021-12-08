using back.domain.entities;

namespace back.domain.DTO.AD_PANTONE
{
    public class AD_PANTONEDTO : IAD_PANTONE
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
