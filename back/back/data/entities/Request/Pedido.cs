using back.data.entities.Enterprise;
using back.data.entities.RequestItem;
using back.data.entities.User;
using back.domain.entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace back.data.entities.Request
{
    public class Pedido : IPedido
    {
        public int Id { get; set; }
        public string Frete { get; set; }
        public int? ClienteCod { get; set; }
        public string Comprador { get; set; }
        public string Observacao { get; set; }
        public bool Remessa { get; set; }
        public int? ClienteRemCod { get; set; }
        public int? CondPagCodTipVenda { get; set; }
        public DateTime? CondPagDhAlter { get; set; }
        public string Status { get; set; }
        public DateTime? DtCriacao { get; set; }
        public DateTime? DtEnvio { get; set; }
        public int? PedSankhyaNuNota { get; set; }
        public bool Orcamento { get; set; }
        public string Estoque { get; set; }
        public bool Pilotagem { get; set; }
        public short? TipoPilotagem { get; set; }
        public int? ProjetoCod { get; set; }
        public int? VendedorPCod { get; set; }
        public char? RegraCif { get; set; }
        public char? LigarAntes { get; set; }
        public string RedpTel { get; set; }
        public string RedpRazao { get; set; }
        public string RedpCnpj { get; set; }
        public char? Redp { get; set; }
        public char? LD { get; set; }
        public short? MediaNeg { get; set; }
        public char? Confirmado { get; set; }
        public string MsgConfirmado { get; set; }
        public string CnpjNovoCliente { get; set; }
        public char? TipoFrete { get; set; }
        public int? ContatoCod { get; set; }
        public int? ContatoCodParc { get; set; }
        public int? RedespachoCodRed { get; set; }
        public DateTime? DtBaseFin { get; set; }
        public DateTime? DtFat { get; set; }
        public string OrdemCompra { get; set; }
        public bool? PedidoItemDtFat { get; set; }
        public bool? PedidoItemOrdemComp { get; set; }
        public int? DiasVenc { get; set; }
        public DateTime? DtCartao { get; set; }
        public int UsuarioId { get; set; }

        [ForeignKey("UsuarioId")]
        public virtual Usuario Usuario { get; set; }
        public int EmpresaId { get; set; }

        [ForeignKey("EmpresaId")]
        public virtual Empresa Empresa { get; set; }

        public virtual ICollection<PedidoItem> PedidoItem { get; set; }

    }
}
