using System.Threading.Tasks;
using back.data.entities.Diretorio;
using back.infra.Data.Context;
using Microsoft.EntityFrameworkCore;

namespace back.infra.Services.DiretorioServices
{
    public static class DiretorioGetByIdService
    {
        public static Task<Diretorio> GetByIdService(this DbAppContextFVUDB_TESTE ctx, int id) => ctx.Diretorio.FirstOrDefaultAsync(x => x.Id == id);
    }
}