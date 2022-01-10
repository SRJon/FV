using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using back.domain.DTO.Book;
using back.domain.DTO.TGFProdutoDTO;

namespace back.domain.DTO.BookAnexo
{
    public class BookAnexoAmostraDTO
    {
        public int Id { get; set; }
        public int? CodProd { get; set; }
        public string Descricao { get; set; }
        public virtual BookAmostraDTO book { get; set; }
        public virtual TGFPROAmostraDTO TGFPRO { get; set; }


    }
}