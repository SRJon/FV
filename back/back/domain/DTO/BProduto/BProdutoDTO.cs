using back.domain.entities;

namespace back.domain.DTO.BProduto
{
    public class BProdutoDTO : IBProduto
    {
        public int Id { get; set; }
        public bool Ativo { get; set; }
    }
}
