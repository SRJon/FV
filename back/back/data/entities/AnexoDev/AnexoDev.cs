using back.domain.entities;
using System;

namespace back.data.entities.AnexoDev
{
    public class AnexoDev : IAnexoDev
    {
        public int Id { get; set; }        
        public string Descricao { get; set; }
        public DateTime? Data { get; set; }        
        public string NomeArq { get; set; }        
        public string Extensao { get; set; }
        public int? Tamanho { get; set; }
        public int? Seq { get; set; }
        public int? SGAD_DEV_ANNuSolDev { get; set; }
    }
}
