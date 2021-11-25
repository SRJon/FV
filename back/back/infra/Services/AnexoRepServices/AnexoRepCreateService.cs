using System.Threading.Tasks;
using back.data.entities.AnexoRep;
using back.infra.Data.Context;

namespace back.infra.Services.AnexoRepServices
{
    public static class AnexoRepCreateService
    {
        public static Task<bool> Create(this DbAppContextFVUDB_TESTE ctx, AnexoRep AnexoRep)
        {
            ctx.AnexoRep.Add(AnexoRep);
            var result = ctx.SaveChanges();
            return result > 0 ? Task.FromResult(true) : Task.FromResult(false);

        }

    }
}