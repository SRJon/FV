using System.Threading.Tasks;
using back.data.entities.User;
using back.infra.Data.Context;
using Microsoft.EntityFrameworkCore;

namespace back.infra.Services.UsuarioServices
{
    public static class UsuarioGetByIdService
    {
        public static Task<Usuario> GetByIdUserService(
            this DbAppContextFVUDB_TESTE ctx, int id) => ctx.Usuario.FirstOrDefaultAsync(x => x.Id == id);
    }
}