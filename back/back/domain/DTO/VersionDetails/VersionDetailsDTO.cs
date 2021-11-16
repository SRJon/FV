namespace back.domain.DTO.VersionDetails
{
    public class VersionDetailsDTO
    {
        public int Id { get; set; }
        public string Type { get; set; }
        public string body { get; set; }
        public int? VersaoProjetosId { get; set; }
    }
}
