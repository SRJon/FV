using System.Threading.Tasks;
using back.data.entities.Projetos;
using back.infra.Data.Context;

namespace back.infra.Services.ProjetosServices
{
    public static class ProjetosCreateService
    {
        public static Task<bool> Create(this DbAppContextFVUDB_TESTE ctx, Projetos Projetos)
        {
            ctx.Projetos.Add(Projetos);
            var result = ctx.SaveChanges();
            return result > 0 ? Task.FromResult(true) : Task.FromResult(false);

        }

    }
}