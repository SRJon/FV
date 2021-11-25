using back.domain.entities;
using System;

namespace back.domain.DTO.BookAnexo
{
    public class BookAnexoDTOUpdateDTO : IBookAnexo
    {
        public int Id { get; set; }
        public int? CodProd { get; set; }
        public string Descricao { get; set; }
        public DateTime? Data { get; set; }
        public string NomeArq { get; set; }
        public string Extensao { get; set; }
        public int? Tamanho { get; set; }
        public int? Seq { get; set; }
    }
}
