using back.domain.entities;

namespace back.domain.DTO.Parametro
{
    public class ParametroDTO : IParametro
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Valor { get; set; }
        public string Descricao { get; set; }
    }
}
