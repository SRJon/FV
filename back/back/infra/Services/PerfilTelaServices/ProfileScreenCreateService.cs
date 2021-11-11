using System.Threading.Tasks;
using back.data.entities.ProfileScreen;
using back.infra.Data.Context;

namespace back.infra.Services.PerfilTelaServices
{
    public static class ProfileScreenCreateService
    {
        public static Task<bool> Create(this DbAppContextFVUDB_TESTE ctx, PerfilTela perfilTela)
        {
            ctx.PerfilTela.Add(perfilTela);
            var result = ctx.SaveChanges();
            return result > 0 ? Task.FromResult(true) : Task.FromResult(false);
        }
    }
}