using back.domain.entities;

namespace back.data.entities.UserCustomizations
{
    public class UserCustomizations : IUserCustomizations
    {
        public int Id { get; set; }
        public string Key { get; set; }
        public string Value { get; set; }
    }
}
