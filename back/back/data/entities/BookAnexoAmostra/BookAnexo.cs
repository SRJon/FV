using back.data.entities.BookAmostra;
using back.data.entities.TGFProduto;
using back.domain.entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace back.data.entities.BookAnexoAmostra
{
    public class BookAnexo : IBookAnexo
    {
        public int Id { get; set; }
        public int? CodProd { get; set; }
        public string Descricao { get; set; }
        public DateTime? Data { get; set; }
        public string NomeArq { get; set; }
        public string Extensao { get; set; }
        public int? Tamanho { get; set; }
        public int? Seq { get; set; }
        public virtual Book book { get; set; }
        [ForeignKey("CodProd")]
        public virtual TGFPRO tgfproduto { get; set; }
    }
}
