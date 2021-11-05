using back.domain.entities;

namespace back.data.entities.Enterprise
{
    public class Empresa : IEmpresa
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public decimal? VlrMinFrete { get; set; }
        public decimal? VlrMinPedido { get; set; }
    }
}