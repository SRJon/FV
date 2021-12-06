using back.domain.entities;

namespace back.domain.DTO.Enterprise
{
    public class EmpresaDTO : IEmpresa
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public decimal? VlrMinFrete { get; set; }
        public decimal? VlrMinPedido { get; set; }
        public short? CodEmp { get; set; }
    }
}