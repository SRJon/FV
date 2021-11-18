using System.Threading.Tasks;
using back.data.entities.AnexoRep;
using back.infra.Data.Context;
using Microsoft.EntityFrameworkCore;

namespace back.infra.Services.AnexoRepServices
{
    public static class AnexoRepGetByIdService
    {
        public static Task<AnexoRep> GetByIdService(this DbAppContextFVUDB_TESTE ctx, int id) => ctx.AnexoRep.FirstOrDefaultAsync(x => x.Id == id);
    }
}