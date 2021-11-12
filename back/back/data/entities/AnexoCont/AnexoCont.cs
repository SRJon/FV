using System;
using System.ComponentModel.DataAnnotations;

namespace back.data.entities.AnexoCont
{
    public class AnexoCont
    {
        public int Id { get; set; }
        [MaxLength(200)]
        public string Descricao { get; set; }
        public DateTime? Data { get; set; }
        [MaxLength(100)]
        public string NomeArq { get; set; }
        [MaxLength(10)]
        public string Extensao { get; set; }
        public int? Tamanho { get; set; }
        public int? Seq { get; set; }
        public int CodPar { get; set; }
    }
}
