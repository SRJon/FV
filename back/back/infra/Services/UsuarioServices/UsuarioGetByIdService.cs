using System.Linq;
using System.Threading.Tasks;
using back.data.entities.User;
using back.infra.Data.Context;
using Microsoft.EntityFrameworkCore;

namespace back.infra.Services.UsuarioServices
{
    public static class UsuarioGetByIdService
    {
        public static async Task<Usuario> GetByIdUserService(
            this DbAppContextFVUDB_TESTE ctx, int id)
        {

            var user = await ctx.Usuario
                .Include(e => e.Perfil)
                .ThenInclude(e => e.PerfilTela)
                .ThenInclude(e => e.Telas)
                .Include(e => e.UsuarioEmp) 
                .ThenInclude( e => e.Empresa)
                .FirstOrDefaultAsync(x => x.Id == id);


            return user;
        }

    }
}