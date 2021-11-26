using System;
using back.domain.entities;

namespace back.domain.DTO.TSIEnderecoDTO
{
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