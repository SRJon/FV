using System.Threading.Tasks;
using back.data.entities.User;
using back.infra.Data.Context;

namespace back.infra.Services.UsuarioServices
{
    public static class UsuarioCreateService
    {

        public static Task<bool> Create(this DbAppContextFVUDB_TESTE ctx, Usuario usuario)
        {
            ctx.Usuario.Add(usuario);
            var result = ctx.SaveChanges();
            return result > 0 ? Task.FromResult(true) : Task.FromResult(false);
        }

    }
}