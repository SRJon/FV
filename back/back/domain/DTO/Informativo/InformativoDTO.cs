using back.domain.entities;

namespace back.domain.DTO.Informativo
{
    public class InformativoDTO : IInformativo
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public string Texto { get; set; }
        public int EmpresaId { get; set; }
    }
}
