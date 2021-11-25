using System.Threading.Tasks;
using back.data.entities.AnexoCont;
using back.infra.Data.Context;
using Microsoft.EntityFrameworkCore;

namespace back.infra.Services.AnexoContServices
{
    public static class AnexoContGetByIdService
    {
        public static Task<AnexoCont> GetByIdService(this DbAppContextFVUDB_TESTE ctx, int id) => ctx.AnexoCont.FirstOrDefaultAsync(x => x.Id == id);
    }
}