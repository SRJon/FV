using back.domain.entities;
using System;

namespace back.domain.DTO.AnexoCont
{
    public class AnexoContDTO : IAnexoCont
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public DateTime? Data { get; set; }
        public string NomeArq { get; set; }
        public string Extensao { get; set; }
        public int? Tamanho { get; set; }
        public int? Seq { get; set; }
        public int CodParc { get; set; }
    }
}
