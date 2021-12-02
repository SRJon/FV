using System.Threading.Tasks;
using back.data.entities.Profile;
using back.infra.Data.Context;
using Microsoft.EntityFrameworkCore;

namespace back.infra.Services.PerfilServices
{
    public static class ProfileGetByIdService
    {
        public static Task<Perfil> GetByIdService(
            this DbAppContextFVUDB_TESTE ctx, int id) =>
            ctx.Perfil
            .Include(p => p.PerfilTela)
            .ThenInclude(p => p.Telas)
            .FirstOrDefaultAsync(x => x.Id == id);
    }
}