using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using back.domain.entities;

namespace back.data.entities.View_AD_SALDO_PARCEIRO
{
    public class AD_SALDO_PARCEIRO : IAD_SALDO_PARCEIRO
    {
        public decimal Saldo { get; set; }
        public int CodParc { get; set; }
        public decimal LimCred { get; set; }
    }
}