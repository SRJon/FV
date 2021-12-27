using back.domain.entities;
using System;

namespace back.domain.DTO.Book
{
    public class BookDTO : IBook
    {
        public int Id { get; set; }
        public int CodProd { get; set; }
        public DateTime DtInclusao { get; set; }
        public bool Ativo { get; set; }
        public DateTime DtAtualizacao { get; set; }
    }
}
