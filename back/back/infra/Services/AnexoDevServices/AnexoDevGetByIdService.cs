using System.Threading.Tasks;
using back.data.entities.AnexoDev;
using back.infra.Data.Context;
using Microsoft.EntityFrameworkCore;

namespace back.infra.Services.AnexoDevServices
{
    public static class AnexoDevGetByIdService
    {
        public static Task<AnexoDev> GetByIdService(this DbAppContextFVUDB_TESTE ctx, int id) => ctx.AnexoDev.FirstOrDefaultAsync(x => x.Id == id);
    }
}