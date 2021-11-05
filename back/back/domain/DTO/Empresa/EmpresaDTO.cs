namespace back.domain.DTO.Empresa
{
    public class EmpresaDTO
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public decimal? VlrMinFrete { get; set; }
        public decimal? VlrMinPedido { get; set; }
    }
}