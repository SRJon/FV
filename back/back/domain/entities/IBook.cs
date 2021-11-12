using System;

namespace back.domain.entities
{
    public interface IBook
    {
        public int id { get; set; }
        public int CodProd { get; set; }
        public DateTime DtInclusao { get; set; }        
        public bool Ativo { get; set; }
    }
}
