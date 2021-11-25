using System.Threading.Tasks;
using back.data.entities.AnexoDev;
using back.infra.Data.Context;

namespace back.infra.Services.AnexoDevServices
{
    public static class AnexoDevCreateService
    {
        public static Task<bool> Create(this DbAppContextFVUDB_TESTE ctx, AnexoDev AnexoDev)
        {
            ctx.AnexoDev.Add(AnexoDev);
            var result = ctx.SaveChanges();
            return result > 0 ? Task.FromResult(true) : Task.FromResult(false);

        }

    }
}