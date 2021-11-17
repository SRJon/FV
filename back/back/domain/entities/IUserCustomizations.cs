namespace back.domain.entities
{
    public interface IUserCustomizations
    {
        public int Id { get; set; }
        public string Key { get; set; }
        public string Value { get; set; }
    }
}
