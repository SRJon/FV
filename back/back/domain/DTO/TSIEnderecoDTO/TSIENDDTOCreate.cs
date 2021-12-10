using System;
using back.data.entities.Abstract_Class;
using back.domain.entities;

namespace back.domain.DTO.TSIEnderecoDTO
{
    public class TSIENDDTOCreate : ToJsonClass, ITSIEND
    {
        public string Nomeend { get; set; }
        public string Tipo { get; set; }
        public DateTime Dtalter { get; set; }
        public string Descricaocorreio { get; set; }
        public string Codlogradouro { get; set; }
        public int? Nuversao { get; set; }
    }
}