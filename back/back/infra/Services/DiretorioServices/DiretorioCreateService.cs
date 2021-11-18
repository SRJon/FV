using System.Threading.Tasks;
using back.data.entities.Diretorio;
using back.infra.Data.Context;

namespace back.infra.Services.DiretorioServices
{
    public static class DiretorioCreateService
    {
        public static Task<bool> Create(this DbAppContextFVUDB_TESTE ctx, Diretorio Diretorio)
        {
            ctx.Diretorio.Add(Diretorio);
            var result = ctx.SaveChanges();
            return result > 0 ? Task.FromResult(true) : Task.FromResult(false);

        }

    }
}