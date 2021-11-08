using System.Threading.Tasks;
using back.data.entities.Screen;
using back.infra.Data.Context;
using Microsoft.EntityFrameworkCore;

namespace back.infra.Services.TelaServices
{
    public static class ScreenGetByIdAsyncService
    {
        public static Task<Tela> GetByIdAsyncService(
            this DbAppContextFVUDB_TESTE ctx, int id) => ctx.Tela.FirstOrDefaultAsync(x => x.Id == id);


    }
}