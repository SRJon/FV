using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using back.domain.entities;

namespace back.data.entities.TSIEndereco
{
    /// <summary>
    /// Classe TSIEND, responsável pelo endereço na base Sankhya
    /// </summary>

    public class TSIEND : ITSIEND
    {
        [Key]
        [Column("CODEND")]
        public int Codend { get; set; }
        public string Nomeend { get; set; }
        public string Tipo { get; set; }
        public DateTime Dtalter { get; set; }
        public string Descricaocorreio { get; set; }
        public string Codlogradouro { get; set; }
        public int? Nuversao { get; set; }
    }
}