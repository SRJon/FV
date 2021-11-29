using back.data.entities.UserEmp;
using back.infra.Data.Context;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace back.infra.Services.UserEmpServices
{
    public static class UsuarioEmpGetByIdService
    {
        public static Task<UsuarioEmp> GetByIdService(this DbAppContextFVUDB_TESTE ctx, int id) => ctx.UsuarioEmp.FirstOrDefaultAsync(x => x.Id == id);
    }
}
