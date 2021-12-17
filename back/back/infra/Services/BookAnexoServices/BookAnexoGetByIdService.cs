using System.Threading.Tasks;
using back.data.entities.BookAnexoAmostra;
using back.infra.Data.Context;
using Microsoft.EntityFrameworkCore;

namespace back.infra.Services.BookAnexoServices
{
    public static class BookAnexoGetByIdService
    {
        public static Task<BookAnexo> GetByIdService(this DbAppContextFVUDB_TESTE ctx, int id) => ctx.BookAnexo.FirstOrDefaultAsync(x => x.Id == id);
    }
}