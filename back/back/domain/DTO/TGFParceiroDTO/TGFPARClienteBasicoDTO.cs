using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace back.domain.DTO.TGFParceiroDTO
{
    public class TGFPARClienteBasicoDTO
    {
        public int codparc { get; set; }
        public string nomeparc { get; set; }
        public string razaosocial { get; set; }
        public string cgc_cpf { get; set; }
        public string email { get; set; }
        public decimal? limcred { get; set; }

    }
}