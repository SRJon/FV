using System.Threading.Tasks;
using back.data.entities.User;
using back.infra.Data.Context;
using Microsoft.EntityFrameworkCore;

namespace back.infra.Services.UsuarioServices
{
    public static class UsuarioGetByLogin
    {
        public static Task<Usuario> GetByLoginService(
            this DbAppContextFVUDB_TESTE ctx, string login) => ctx.Usuario.FirstOrDefaultAsync(x => x.Login.ToLower() == login.ToLower());
    }
}