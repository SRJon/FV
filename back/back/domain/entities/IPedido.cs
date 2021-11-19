using System;

namespace back.domain.entities
{
    public interface IPedido
    {
        public int Id { get; set; }
        public string Frete { get; set; }
        public Nullable<int> ClienteCod { get; set; }
        public string Comprador { get; set; }
        public string Observacao { get; set; }
        public bool Remessa { get; set; }
        public Nullable<int> ClienteRemCod { get; set; }
        public Nullable<int> CondPagCodTipVenda { get; set; }
        public Nullable<DateTime> CondPagDhAlter { get; set; }
        public string Status { get; set; }
        public Nullable<DateTime> DtCriacao { get; set; }
        public Nullable<DateTime> DtEnvio { get; set; }
        public Nullable<int> PedSankhyaNuNota { get; set; }
        public bool Orcamento { get; set; }
        public int UsuarioId { get; set; }
        public int EmpresaId { get; set; }
        public string Estoque { get; set; }
        public bool Pilotagem { get; set; }
        public Nullable<Int16> TipoPilotagem { get; set; }
        public Nullable<int> ProjetoCod { get; set; }
        public Nullable<int> VendedorPCod { get; set; }
        public Nullable<char> RegraCif { get; set; }
        public Nullable<char> LigarAntes { get; set; }
        public string RedpTel { get; set; }
        public string RedpRazao { get; set; }
        public string RedpCnpj { get; set; }
        public Nullable<char> Redp { get; set; }
        public Nullable<char> LD { get; set; }
        public Nullable<Int16> MediaNeg { get; set; }
        public Nullable<char> Confirmado { get; set; }
        public string MsgConfirmado { get; set; }
        public string CnpjNovoCliente { get; set; }
        public Nullable<char> TipoFrete { get; set; }
        public Nullable<int> ContatoCod { get; set; }
        public Nullable<int> ContatoCodParc { get; set; }
        public Nullable<int> RedespachoCodRed { get; set; }
        public Nullable<DateTime> DtBaseFin { get; set; }
        public Nullable<DateTime> DtFat { get; set; }
        public string OrdemCompra { get; set; }
        public Nullable<bool> PedidoItemDtFat { get; set; }
        public Nullable<bool> PedidoItemOrdemComp { get; set; }
        public Nullable<int> DiasVenc { get; set; }
        public Nullable<DateTime> DtCartao { get; set; }

    }
}
