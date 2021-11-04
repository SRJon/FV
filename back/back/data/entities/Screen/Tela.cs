using System;
using System.ComponentModel.DataAnnotations;
using back.domain.entities;

namespace back.data.entities.Screen
{
    public class Tela : ITela
    {
        [Key]
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
        public Nullable<decimal> SgTelaId { get; set; }
    }
}