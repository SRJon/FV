using System;

namespace back.domain.entities
{
    public interface IAnexoCont
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public DateTime? Data { get; set; }
        public string NomeArq { get; set; }
        public string Extensao { get; set; }
        public Nullable<int> Tamanho { get; set; }
        public Nullable<int> Seq { get; set; }
        public int CodPar { get; set; }

    }
}
