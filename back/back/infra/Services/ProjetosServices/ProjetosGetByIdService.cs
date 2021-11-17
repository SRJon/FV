using System.Threading.Tasks;
using back.data.entities.Projetos;
using back.infra.Data.Context;
using Microsoft.EntityFrameworkCore;

namespace back.infra.Services.ProjetosServices
{
    public static class ProjetosGetByIdService
    {
        public static Task<Projetos> GetByIdService(this DbAppContextFVUDB_TESTE ctx, int id) => ctx.Projetos.FirstOrDefaultAsync(x => x.Id == id);
    }
}