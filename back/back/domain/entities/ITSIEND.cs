using System;

namespace back.domain.entities
{
    public interface ITSIEND
    {
        public string Nomeend { get; set; }
        public string Tipo { get; set; }
        public DateTime Dtalter { get; set; }
        public string Descricaocorreio { get; set; }
        public string Codlogradouro { get; set; }
        public Nullable<int> Nuversao { get; set; }
    }
}