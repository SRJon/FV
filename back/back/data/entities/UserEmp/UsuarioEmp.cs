using back.domain.entities;

namespace back.data.entities.UserEmp
{
    public class UsuarioEmp : IUsuarioEmp
    {
        public int Id { get; set; }
        public int UsuarioId { get; set; }
        public int EmpresaId { get; set; }
    }
}
