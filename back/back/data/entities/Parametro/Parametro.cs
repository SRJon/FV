using back.domain.entities;

namespace back.data.entities.Parametro
{
    public class Parametro : IParametro
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Valor { get; set; }
        public string Descricao { get; set; }
    }
}
