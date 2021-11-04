using System;
using back.domain.entities;

namespace back.domain.DTO.Tela
{
    public class TelaGetAllDTO : ITela
    {
        public decimal TelaId { get; set; }
        public string TelaNome { get; set; }
        public string TelaUrl { get; set; }
        public string TelaAddUrl { get; set; }
        public string TelaTarget { get; set; }
        public bool TelaNivel { get; set; }
        public Int16 TelaOrdem { get; set; }
        public string TelaModulo { get; set; }
        public bool TelaSd { get; set; }
        public string TelaImagemSd { get; set; }
        public string TelaIconClass { get; set; }
        public decimal? SgTelaId { get; set; }
    }
}