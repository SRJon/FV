using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using back.domain.DTO.BookAnexo;

namespace back.domain.DTO.Book
{
    public class BookAmostraDTO
    {
        public int Id { get; set; }
        public int CodProd { get; set; }
        public DateTime DtAtualizacao { get; set; }
        public virtual ICollection<BookAnexoAmostraDTO> bookAnexo { get; set; }

    }
}