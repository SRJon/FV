using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace back.domain.entities
{
    public interface IAD_SALDO_PARCEIRO
    {
        public decimal Saldo { get; set; }
        public int CodParc { get; set; }
        public decimal LimCred { get; set; }
    }
}