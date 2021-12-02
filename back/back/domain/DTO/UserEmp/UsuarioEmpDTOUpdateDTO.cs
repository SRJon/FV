using back.domain.entities;

namespace back.domain.DTO.UserEmp
{
    public class UsuarioEmpDTOUpdateDTO : IUsuarioEmp
    {
        public int Id { get; set; }
        public int UsuarioId { get; set; }
        public int EmpresaId { get; set; }
    }
}
