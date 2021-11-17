using System;

namespace back.domain.entities
{
    public interface IVersaoProjetos
    {
        public int Id { get; set; }
        public string Versao { get; set; }
        public Nullable<int> ProjId { get; set; }
        public DateTime? Data { get; set; }
    }
}
