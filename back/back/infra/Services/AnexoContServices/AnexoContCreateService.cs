using System.Threading.Tasks;
using back.data.entities.AnexoCont;
using back.infra.Data.Context;

namespace back.infra.Services.AnexoContServices
{
    public static class AnexoContCreateService
    {
        public static Task<bool> Create(this DbAppContextFVUDB_TESTE ctx, AnexoCont AnexoCont)
        {
            ctx.AnexoCont.Add(AnexoCont);
            var result = ctx.SaveChanges();
            return result > 0 ? Task.FromResult(true) : Task.FromResult(false);

        }

    }
}