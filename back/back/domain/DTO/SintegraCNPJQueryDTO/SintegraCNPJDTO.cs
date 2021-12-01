using System;
using System.Collections.Generic;
using back.domain.entities;

namespace back.domain.DTO.SintegraCNPJQueryDTO
{
    public class SintegraCNPJDTO : ISintegraCNPJ
    {
        public string DataSituacao { get; set; }
        public string Complemento { get; set; }
        public string Tipo { get; set; }
        public string Nome { get; set; }
        public string Uf { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }
        public List<Qsa> Qsa { get; set; }
        public string Situacao { get; set; }
        public string Bairro { get; set; }
        public string Logradouro { get; set; }
        public long Numero { get; set; }
        public string Cep { get; set; }
        public string Municipio { get; set; }
        public string Porte { get; set; }
        public string Abertura { get; set; }
        public string NaturezaJuridica { get; set; }
        public string Cnpj { get; set; }
        public DateTimeOffset UltimaAtualizacao { get; set; }
        public string Status { get; set; }
        public string Fantasia { get; set; }
        public string Efr { get; set; }
        public string MotivoSituacao { get; set; }
        public string SituacaoEspecial { get; set; }
        public string DataSituacaoEspecial { get; set; }
        public string CapitalSocial { get; set; }
        public List<Atividade> AtividadePrincipal { get; set; }
        public List<Atividade> AtividadesSecundarias { get; set; }
        public Extra Extra { get; set; }
        public Billing Billing { get; set; }


    }
    public partial class Atividade
    {
        public string Text { get; set; }
        public string Code { get; set; }
    }

    public partial class Billing
    {
        public bool Free { get; set; }
        public bool Database { get; set; }
    }

    public partial class Extra
    {
    }

    public partial class Qsa
    {
        public string Qual { get; set; }
        public string Nome { get; set; }
        public string QualRepLegal { get; set; }
        public string NomeRepLegal { get; set; }
    }
}