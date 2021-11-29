using System.Threading.Tasks;
using back.data.entities.ProfileScreen;
using back.infra.Data.Context;
using Microsoft.EntityFrameworkCore;

namespace back.infra.Services.PerfilTelaServices
{
    public static class ProfileScreenGetByIdService
    {
        public static Task<PerfilTela> GetByIdService(
            this DbAppContextFVUDB_TESTE ctx, int id) => ctx.PerfilTela.Include(p => p.Perfil).ThenInclude(u => u.Usuario).Include(e => e.Telas).ThenInclude(a => a.tela).FirstOrDefaultAsync(x => x.Id == id);

    }
}