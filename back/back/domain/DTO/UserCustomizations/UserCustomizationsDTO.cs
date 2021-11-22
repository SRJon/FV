using back.domain.entities;

namespace back.domain.DTO.UserCustomizations
{
    public class UserCustomizationsDTO : IUserCustomizations
    {
        public int Id { get; set; }
        public string Key { get; set; }
        public string Value { get; set; }
    }
}
