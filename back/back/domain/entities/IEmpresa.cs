using System;

namespace back.domain.entities
{
    public interface IEmpresa
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public Nullable<decimal> VlrMinFrete { get; set; }
        public Nullable<decimal> VlrMinPedido { get; set; }
    }
}