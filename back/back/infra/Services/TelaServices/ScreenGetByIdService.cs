using System.Threading.Tasks;
using back.data.entities.Screen;
using back.infra.Data.Context;
using Microsoft.EntityFrameworkCore;

namespace back.infra.Services.TelaServices
{
    public static class ScreenGetByIdService
    {
        public static Task<Tela> GetByIdService(
            this DbAppContextFVUDB_TESTE ctx, int id)
        {
            var b = ctx.Tela.Include(e => e.tela).FirstOrDefaultAsync(x => x.Id == id);
            return b;
        }
    }
}