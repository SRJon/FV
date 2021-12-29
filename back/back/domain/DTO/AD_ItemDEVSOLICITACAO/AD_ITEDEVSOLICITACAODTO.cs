using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using back.domain.entities;

namespace back.domain.DTO.AD_ItemDEVSOLICITACAO
{
    public class AD_ITEDEVSOLICITACAODTO : IAD_ITEDEVSOLICITACAO
    {
        public int nusoldev { get; set; }
        public int sequencia { get; set; }
        public int? codprod { get; set; }
        public double? qtdneg { get; set; }
        public string ocorrencia { get; set; }
        public double? preco { get; set; }
        public double? aliqipi { get; set; }

    }
}