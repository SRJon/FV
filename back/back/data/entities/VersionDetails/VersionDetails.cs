using back.domain.entities;

namespace back.data.entities.VersionDetails
{
    public class VersionDetails : IVersionDetails
    {
        public int Id { get; set; }
        public string Type { get; set; }
        public string body { get; set; }
        public int? VersaoProjetosId { get; set; }
    }
}
