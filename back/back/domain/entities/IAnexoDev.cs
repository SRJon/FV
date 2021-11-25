using System;

namespace back.domain.entities
{
    public interface IAnexoDev
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public Nullable<DateTime> Data { get; set; }
        public string NomeArq { get; set; }
        public string Extensao { get; set; }
        public Nullable<int> Tamanho { get; set; }
        public Nullable<int> Seq { get; set; }
        public Nullable<int> SGAD_DEV_ANNuSolDev { get; set; }


    }
}
