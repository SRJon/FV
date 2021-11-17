using back.data.entities.Enterprise;
using back.domain.entities;
using System;

namespace back.data.entities.Informativo
{
    public class Informativo : IInformativo
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public string Texto { get; set; }

        public Empresa ToModel()
        {
            throw new NotImplementedException();
        }
    }
}
