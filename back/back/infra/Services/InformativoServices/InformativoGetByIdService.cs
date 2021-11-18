using System.Threading.Tasks;
using back.data.entities.Informativo;
using back.infra.Data.Context;
using Microsoft.EntityFrameworkCore;

namespace back.infra.Services.InformativoServices
{
    public static class InformativoGetByIdService
    {
        public static Task<Informativo> GetByIdService(this DbAppContextFVUDB_TESTE ctx, int id) => ctx.Informativo.FirstOrDefaultAsync(x => x.Id == id);
    }
}