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

            // foreach (relation_member rm in rel.relation_members)
            // {
            //     ctx.Entry(rm).Reference(r => r.way).Query()
            //         .Include(w => w.way_nodes.Select(wn => wn.node))
            //         .Load();
            // }
            var user = await ctx.Usuario
            .Include(e => e.Perfil)
            .ThenInclude(e => e.PerfilTela)
            .ThenInclude(e => e.Telas)
            .FirstOrDefaultAsync(x => x.Id == id);


            // user.Perfil= ctx.
            return user;
        }

    }
}