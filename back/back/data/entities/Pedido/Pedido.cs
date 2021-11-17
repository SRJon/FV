using back.domain.entities;
using System;
using System.ComponentModel.DataAnnotations;

namespace back.data.entities.Pedido
{
    public class Pedido : IPedido
    {
        public int Id { get; set; }
        [MaxLength(2)]
        public string Frete { get; set; }
        public int ClienteCod { get; set; }
        [MaxLength(100)]
        public string Comprador { get; set; }
        public string Observacao { get; set; }
        public Boolean? Remessa { get; set; }
        public int? ClienteRemCod{ get; set; }
        public int? CondPagCodTipVenda { get; set; }
        public DateTime? CondPagDhAlter{ get; set; }
        [MaxLength(2)]
        public string Status{ get; set; }
        public DateTime? DtCriacao{ get; set; }
        public DateTime? DtEnvio{ get; set; }
        public int? PedSankhyaNuNota { get; set; }
        public Boolean Orcamento { get; set; }
        public int UsuarioId { get; set; }
        public int EmpresaId { get; set; }
        [MaxLength(2)]
        public string Estoque { get; set; }
        public Boolean? Pilotagem { get; set; }
        public Int16? TipoPilotagem { get; set; }
        public int? ProjetoCod { get; set; }
        public int? VendedorPCod { get; set; }
        public char? RegraCif { get; set; }
        public char? LigarAntes { get; set; }
        [MaxLength(20)]
        public string RedpTel { get; set; }
        [MaxLength(150)]
        public string RedpRazao { get; set; }
        [MaxLength(30)]
        public string RedpCnpj { get; set; }
        public char? Redp { get; set; }
        public char? LD { get; set; }
        public Int16? MediaNeg { get; set; }
        public char? Confirmado { get; set; }
        public string MsgConfirmado { get; set; }
        [MaxLength(20)]
        public string CnpjNovoCliente { get; set; }
        public char? TipoFrete { get; set; }
        public int? ContatoCod { get; set; }
        public int? ContatoCodParc { get; set; }
        public int? RedespachoCodRed { get; set; }
        public DateTime? DtBaseFin { get; set; }
        public DateTime? DtFat { get; set; }
        [MaxLength(40)]
        public string OrdemCompra { get; set; }
        public Boolean? PedidoItemDtFat { get; set; }
        public Boolean? PedidoItemOrdemComp { get; set; }
        public int? DiasVenc { get; set; }
        public DateTime?  DtCartao  { get; set; }
    }
}
