using System.Threading.Tasks;
using back.data.entities.UserEmp;
using back.infra.Data.Context;


namespace back.infra.Services.UserEmpServices
{
    public static class UsuarioEmpCreateService
    {
        public static Task<bool> Create(this DbAppContextFVUDB_TESTE ctx, UsuarioEmp UsuarioEmp)
        {
            ctx.UsuarioEmp.Add(UsuarioEmp);
            var result = ctx.SaveChanges();

            return result > 0 ? Task.FromResult(true) : Task.FromResult(false);

        }
    }
}
