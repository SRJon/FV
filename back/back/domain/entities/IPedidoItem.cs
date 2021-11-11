using System;

namespace back.domain.entities
{
    public interface IPedidoItem
    {
        public int Id { get; set; }
        public int PedidoId { get; set; }
        public int ProdCodProd { get; set; }
        public decimal? Qtd { get; set; }
        public decimal? Preco { get; set; }
        public decimal? Total { get; set; }
        public decimal? PercDesc { get; set; }
        public Nullable<int> CodLocal { get; set; }
        public decimal? PercDescTotal { get; set; }
        public decimal? PercDesc2 { get; set; }
        public Nullable<int> NuTab { get; set; }
        public decimal? VlrIpi { get; set; }
        public decimal? PercIpi { get; set; }
        public decimal? PrecoTab { get; set; }
        public Boolean? ForaPolitica { get; set; }

    }
}
