using System.Threading.Tasks;
using back.data.entities.Informativo;
using back.infra.Data.Context;

namespace back.infra.Services.InformativoServices
{
    public static class InformativoCreateService
    {
        public static Task<bool> Create(this DbAppContextFVUDB_TESTE ctx, Informativo Informativo)
        {
            ctx.Informativo.Add(Informativo);
            var result = ctx.SaveChanges();
            return result > 0 ? Task.FromResult(true) : Task.FromResult(false);

        }

    }
}