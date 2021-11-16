using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace back.data.entities.AnexoDev
{
    public class AnexoDev
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
        public int? SGAD_DEV_ANNuSolDev { get; set; }
    }
}
