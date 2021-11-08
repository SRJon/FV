using back.domain.entities;

namespace back.domain.DTO.Empresa
{
    public class EmpresaDTOUpdateDTO : IEmpresa
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public decimal? VlrMinFrete { get; set; }
        public decimal? VlrMinPedido { get; set; }
    }
}