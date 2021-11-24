using System.Threading.Tasks;
using back.data.entities.Profile;
using back.infra.Data.Context;
using Microsoft.EntityFrameworkCore;

namespace back.infra.Services.PerfilServices
{
    public static class ProfileGetNameByIdService
    {
        public static Task<Perfil> GetNameByIdService(
            this DbAppContextFVUDB_TESTE ctx, int id) => ctx.Perfil.FirstOrDefaultAsync(x => x.Id == id);
    }
}