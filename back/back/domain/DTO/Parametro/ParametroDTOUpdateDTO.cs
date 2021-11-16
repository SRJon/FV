using back.domain.entities;
using System;

namespace back.domain.DTO.Parametro
{
    public class ParametroDTOUpdateDTO : IParametro
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Valor { get; set; }
        public string Descricao { get; set; }
    }
}
