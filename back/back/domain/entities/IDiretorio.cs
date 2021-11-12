using System;

namespace back.domain.entities
{
    public interface IDiretorio
    {
        public int Id { get; set; }
        public Int16 Tipo { get; set; }
        public string Link { get; set;}
        public string Virtual { get; set; }

    }
}
