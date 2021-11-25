using back.domain.entities;
using System;

namespace back.data.entities.BProdutoImg
{
    public class BProdutoImg : IBProdutoImg
    {
        public int Id { get; set; }
        public int FCodProd { get; set; }
        public int BProdutoId { get; set; }
        public DateTime Data { get; set; }
        public bool Ativo { get; set; }
        public string NomeArq { get; set; }
        public string Extensao { get; set; }
        public int Tamanho { get; set; }
        public int Seq { get; set; }
    }
}
