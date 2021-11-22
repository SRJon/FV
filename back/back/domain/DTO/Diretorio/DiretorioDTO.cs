using back.domain.entities;

namespace back.domain.DTO.Diretorio
{
    public class DiretorioDTO : IDiretorio
    {
        public int Id { get; set; }
        public short Tipo { get; set; }
        public string Link { get; set; }
        public string Virtual { get; set; }
    }
}
