using back.domain.entities;
using System;

namespace back.domain.DTO.Diretorio
{
    public class DiretorioDTOUpdateDTO : IDiretorio
    {
        public int Id { get; set; }
        public short Tipo { get; set; }
        public string Link { get; set; }
        public string Virtual { get; set; }
    }
}
