namespace back.domain.entities
{
    public interface IParametro
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Valor { get; set; }
        public string Descricao { get; set; }
    }
}
