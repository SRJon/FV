using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace back.domain.entities
{
    public interface IBookAnexo
    {
        public int Id { get; set; }
        public Nullable<int> CodProd { get; set; }
        public string Descricao { get; set; }
        public DateTime? Data { get; set; }
        public string NomeArq { get; set; }
        public string Extensao { get; set; }
        public Nullable<int> Tamanho { get; set; }
        public Nullable<int> Seq { get; set; }
    }
}
