using System.Threading.Tasks;
using back.data.entities.Profile;
using back.infra.Data.Context;

namespace back.infra.Services.PerfilServices
{
    public static class ProfileCreateService
    {
        public static Task<bool> Create(this DbAppContextFVUDB_TESTE ctx, Perfil perfil)
        {
            ctx.Perfil.Add(perfil);
            var result = ctx.SaveChanges();
            return result > 0 ? Task.FromResult(true) : Task.FromResult(false);
        }
    }

}