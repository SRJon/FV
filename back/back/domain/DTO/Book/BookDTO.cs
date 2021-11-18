using back.domain.entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace back.domain.DTO.Book
{
    public class BookDTO : IBook
    {
        public int Id { get; set; }
        public int CodProd { get; set; }
        public DateTime DtInclusao { get; set; }
        public bool Ativo { get; set; }
    }
}
