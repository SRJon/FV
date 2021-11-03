namespace back.data.entities.Tela
{
    public class Tela
    {
        public long TelaId { get; set; }
        public string TelaNome { get; set; }
        public string TelaUrl { get; set; }
        public string TelaAddUrl { get; set; }
        public string TelaTarget { get; set; }
        public bool TelaNivel { get; set; }
        public long TelaOrdem { get; set; }
        public string TelaModulo { get; set; }
        public bool TelaSd { get; set; }
        public string TelaImagemSd { get; set; }
        public string TelaIconClass { get; set; }
    }
}