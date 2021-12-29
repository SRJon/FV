using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using back.domain.DTO.Enterprise;
using back.domain.DTO.TGFParceiroDTO;
using back.domain.DTO.TGFTPVendaDTO;

namespace back.domain.DTO.Request
{
    public class PedidoClienteDTO
    {
        public int Id { get; set; }
        public int EmpresaId { get; set; }
        public string Comprador { get; set; }
        public string Estoque { get; set; }
        public string Frete { get; set; }
        public bool Remessa { get; set; }
        public string Status { get; set; }
        public int? ClienteCod { get; set; }//CODPAR - TGFPAR
        public int? CondPagCodTipVenda { get; set; }//CODTIPVENDA - TGFTPV
        public DateTime? CondPagDhAlter { get; set; }//DHALTER - TGFTPV
        public bool Pilotagem { get; set; }
        public int? ProjetoCod { get; set; }
        public char? LD { get; set; }
        public DateTime? DtEnvio { get; set; }

        public virtual EmpresaDTO Empresa { get; set; }
        public virtual TGFPARPedidoClienteDTO TGFPAR { get; set; }
        public virtual TGFTPVPedidoClienteDTO TGFTPV { get; set; }
    }
}