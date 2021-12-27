using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace back.domain.entities
{
    public interface IAD_ITEDEVSOLICITACAO
    {
        public int nusoldev { get; set; }
        public int sequencia { get; set; }
        public Nullable<int> codprod { get; set; }
        public Nullable<double> qtdneg { get; set; }
        public string ocorrencia { get; set; }
        public Nullable<double> preco { get; set; }
        public Nullable<double> aliqipi { get; set; }

    }
}