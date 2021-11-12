using System;

namespace back.domain.entities
{
    public interface IBProdutoImg
    {
        public int Id { get; set; }
        public int FCodProd { get; set; }
        public int CodProd { get; set; }        
        public DateTime Data { get; set; }
        public bool Ativo { get; set; }
        public string NomeArq { get; set; }
        public string Extensao { get; set; }
        public int Tamanho { get; set; }
        public int Seq { get; set; }
    }
}
