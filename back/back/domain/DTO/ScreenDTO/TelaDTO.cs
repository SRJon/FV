using System;
using back.data.entities.Screen;
using back.domain.entities;

namespace back.domain.DTO.ScreenDTO
{
    public class TelaDTO : ITela
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Url { get; set; }
        public string AddUrl { get; set; }
        public string Target { get; set; }
        public bool Nivel { get; set; }
        public Int16 Ordem { get; set; }
        public string Modulo { get; set; }
        public bool Sd { get; set; }
        public string ImagemSd { get; set; }
        public string IconClass { get; set; }
        public int? TelaId { get; set; }
        public virtual TelaDTOChild tela { get; set; }
    }
}