using back.data.entities.BookAnexoAmostra;
using back.domain.entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace back.data.entities.BookAmostra
{
    public class Book : IBook
    {
        public int Id { get; set; }
        public int CodProd { get; set; }
        public DateTime DtInclusao { get; set; }
        public bool Ativo { get; set; }
        [ForeignKey("CodProd")]
        public virtual ICollection<BookAnexo> bookAnexo { get; set; }
        public DateTime DtAtualizacao { get; set; }
    }
}
