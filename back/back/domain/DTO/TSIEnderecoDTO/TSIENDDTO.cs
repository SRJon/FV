using System;
using back.domain.entities;

namespace back.domain.DTO.TSIEnderecoDTO
{
    /// <summary>
    /// DTO da Classe TSIEND, responsável pelo endereço na base de dados do Sankhya
    /// </summary>
    public class TSIENDDTO : ITSIEND
    {
        public int Codend { get; set; }
        public string Nomeend { get; set; }
        public string Tipo { get; set; }
        public DateTime Dtalter { get; set; }
        public string Descricaocorreio { get; set; }
        public string Codlogradouro { get; set; }
        public int? Nuversao { get; set; }
    }
}