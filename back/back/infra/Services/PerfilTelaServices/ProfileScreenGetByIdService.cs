using System.Threading.Tasks;
using back.data.entities.ProfileScreen;
using back.infra.Data.Context;
using Microsoft.EntityFrameworkCore;

namespace back.infra.Services.PerfilTelaServices
{
    public static class ProfileScreenGetByIdService
    {
        public static Task<PerfilTela> GetByIdService(
            this DbAppContextFVUDB_TESTE ctx, int id) => ctx.PerfilTela.FirstOrDefaultAsync(x => x.Id == id);

    }
}