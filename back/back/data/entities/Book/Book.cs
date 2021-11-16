using back.domain.entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace back.data.entities.Book
{
    public class Book : IBook
    {
        public int id { get; set; }
        public int CodProd { get; set; }
        public DateTime DtInclusao { get; set; }
        public bool Ativo { get; set; }
    }
}
