using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace back.domain.DTO.TGFTPVendaDTO
{
    public class TGFTPVPedidoClienteDTO
    {
        public short Codtipvenda { get; set; }
        public DateTime Dhalter { get; set; }
        public string Descrtipvenda { get; set; }
        public string Subtipovenda { get; set; }
    }
}