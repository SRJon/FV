using System.Threading.Tasks;
using back.data.entities.VersaoProjetos;
using back.infra.Data.Context;
using Microsoft.EntityFrameworkCore;

namespace back.infra.Services.VersaoProjetosServices
{
    public static class VersaoProjetosGetByIdService
    {
        public static Task<VersaoProjetos> GetByIdService(this DbAppContextFVUDB_TESTE ctx, int id) => ctx.VersaoProjetos.FirstOrDefaultAsync(x => x.Id == id);
    }
}