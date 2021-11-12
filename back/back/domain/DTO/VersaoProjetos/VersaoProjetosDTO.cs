using System;

namespace back.domain.DTO.VersaoProjetos
{
    public class VersaoProjetosDTO
    {
        public int Id { get; set; }
        public string Versao { get; set; }
        public int? ProjId { get; set; }
        public DateTime? Data { get; set; }
    }
}
