using back.domain.entities;
using System;

namespace back.domain.DTO.UserCustomizations
{
    public class UserCustomizationsDTOUpdateDTO : IUserCustomizations
    {
        public int Id { get; set; }
        public string Key { get; set; }
        public string Value { get; set; }
    }
}
