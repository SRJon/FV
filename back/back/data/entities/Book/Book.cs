using back.domain.entities;
using System;

namespace back.data.entities.Book
{
    public class Book : IBook
    {        
        public int Id { get; set; }
        public int CodProd { get; set; }
        public DateTime DtInclusao { get; set; }
        public bool Ativo { get; set; }      
    }
}
