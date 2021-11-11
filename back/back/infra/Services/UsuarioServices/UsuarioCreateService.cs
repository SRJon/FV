using System.Threading.Tasks;
using back.data.entities.User;
using back.infra.Data.Context;
using back.infra.Services.Authentication;

namespace back.infra.Services.UsuarioServices
{
    public static class UsuarioCreateService
    {

        public static Task<bool> Create(this DbAppContextFVUDB_TESTE ctx, Usuario usuario)
        {
            try
            {
                usuario.SenhaFV = PasswordHash.HashPassword(usuario.Senha);
                ctx.Usuario.Add(usuario);
                var result = ctx.SaveChanges();
                return result > 0 ? Task.FromResult(true) : Task.FromResult(false);
            }
            catch (System.Exception e)
            {

                throw e;
            }

        }

    }
}