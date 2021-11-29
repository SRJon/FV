using back.domain.DTO.Enterprise;

namespace back.domain.DTO.UserEmp
{
    public class UsuarioEmpresaDTO
    {
        public int Id { get; set; }        
        public int EmpresaId { get; set; }     
        public virtual EmpresaDTO Empresa { get; set; }
    }
}
