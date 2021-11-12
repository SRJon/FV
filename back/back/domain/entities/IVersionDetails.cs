using System;

namespace back.domain.entities
{
    public interface IVersionDetails
    {
        public int Id { get; set; }
        public string Type { get; set; }
        public string body { get; set; }
        public Nullable<int> VersaoProjetosId { get; set; }


    }
}
