using System;

namespace back.domain.entities
{
    public interface IBook
    {
        public int Id { get; set; }
        public int CodProd { get; set; }
        public DateTime DtInclusao { get; set; }
        public DateTime DtAtualizacao { get; set; }
        public bool Ativo { get; set; }
    }
}
