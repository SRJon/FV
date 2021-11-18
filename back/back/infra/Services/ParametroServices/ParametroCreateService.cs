using System.Threading.Tasks;
using back.data.entities.Parametro;
using back.infra.Data.Context;

namespace back.infra.Services.ParametroServices
{
    public static class ParametroCreateService
    {
        public static Task<bool> Create(this DbAppContextFVUDB_TESTE ctx, Parametro Parametro)
        {
            ctx.Parametro.Add(Parametro);
            var result = ctx.SaveChanges();
            return result > 0 ? Task.FromResult(true) : Task.FromResult(false);

        }

    }
}