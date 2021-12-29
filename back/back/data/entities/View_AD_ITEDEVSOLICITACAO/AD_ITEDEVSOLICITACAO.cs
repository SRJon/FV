using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using back.domain.entities;

namespace back.data.entities.View_AD_ITEDEVSOLICITACAO
{
    public class AD_ITEDEVSOLICITACAO : IAD_ITEDEVSOLICITACAO
    {

        [Key]
        [Column("NUSOLDEV")]
        public int nusoldev { get; set; }
        [Key]
        [Column("SEQUENCIA")]
        public int sequencia { get; set; }
        public int? codprod { get; set; }
        public double? qtdneg { get; set; }
        public string ocorrencia { get; set; }
        public double? preco { get; set; }
        public double? aliqipi { get; set; }
    }
}