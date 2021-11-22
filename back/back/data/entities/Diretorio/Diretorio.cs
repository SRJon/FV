using back.domain.entities;

namespace back.data.entities.Diretorio
{
    public class Diretorio : IDiretorio
    {
        public int Id { get; set; }
        public short Tipo { get; set; }
        public string Link { get; set; }
        public string Virtual { get; set; }
    }
}
