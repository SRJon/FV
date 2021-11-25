using back.domain.entities;

namespace back.data.entities.BProduto
{
    public class BProduto : IBProduto
    {
        public int Id { get; set; }
        public bool Ativo { get; set; }
    }
}
