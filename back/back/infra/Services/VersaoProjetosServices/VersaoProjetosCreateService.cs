using System.Threading.Tasks;
using back.data.entities.VersaoProjetos;
using back.infra.Data.Context;

namespace back.infra.Services.VersaoProjetosServices
{
    public static class VersaoProjetosCreateService
    {
        public static Task<bool> Create(this DbAppContextFVUDB_TESTE ctx, VersaoProjetos VersaoProjetos)
        {
            ctx.VersaoProjetos.Add(VersaoProjetos);
            var result = ctx.SaveChanges();
            return result > 0 ? Task.FromResult(true) : Task.FromResult(false);

        }

    }
}