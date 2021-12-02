using back.data.entities.Enterprise;
using back.domain.entities;

namespace back.domain.DTO.UserEmp
{
    public class UsuarioEmpDTO : IUsuarioEmp
    {
        public int Id { get; set; }
        public int UsuarioId { get; set; }
        public int EmpresaId { get; set; }     
        public virtual Empresa empresa { get; set; }
    }
}
