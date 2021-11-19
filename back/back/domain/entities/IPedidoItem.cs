using System;

namespace back.domain.entities
{
    public interface IPedidoItem
    {
        public int Id { get; set; }
        public int PedidoId { get; set; }
        public int ProdCodProd { get; set; }
        public Nullable<decimal> Qtd { get; set; }
        public Nullable<decimal> Preco { get; set; }
        public Nullable<decimal> Total { get; set; }
        public Nullable<decimal> PercDesc { get; set; }
        public Nullable<int> CodLocal { get; set; }
        public Nullable<decimal> PercDescTotal { get; set; }
        public Nullable<decimal> PercDesc2 { get; set; }
        public Nullable<int> NuTab { get; set; }
        public Nullable<decimal> VlrIpi { get; set; }
        public Nullable<decimal> PercIpi { get; set; }
        public Nullable<decimal> PrecoTab { get; set; }
        public Boolean? ForaPolitica { get; set; }

    }
}
