using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using back.domain.entities;

namespace back.domain.DTO.AD_VGFRPVDTO
{
    public class AD_VGFRPVSaldoDTO : IAD_VGFRPV
    {
        public short Codvend { get; set; }
        public string Nomvend { get; set; }
        public int Codparc { get; set; }
        public string Nomeparc { get; set; }
        public string Cgc_cpf { get; set; }
        public int? Atraso { get; set; }
        public decimal Saldo { get; set; }
        public decimal LimCred { get; set; }
    }
}