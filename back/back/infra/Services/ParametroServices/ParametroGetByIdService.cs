using System.Threading.Tasks;
using back.data.entities.Parametro;
using back.infra.Data.Context;
using Microsoft.EntityFrameworkCore;

namespace back.infra.Services.ParametroServices
{
    public static class ParametroGetByIdService
    {
        public static Task<Parametro> GetByIdService(this DbAppContextFVUDB_TESTE ctx, int id) => ctx.Parametro.FirstOrDefaultAsync(x => x.Id == id);
    }
}