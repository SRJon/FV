using System;

namespace back.domain.entities
{
    public interface IPerfil
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public Nullable<int> PER_COD { get; set; }
        public Nullable<int> PerfilId { get; set; }
    }
}