using System.Collections.Generic;
using System.Threading.Tasks;
using back.data.entities.BookAnexoAmostra;
using back.infra.Data.Context;
using Microsoft.EntityFrameworkCore;

namespace back.infra.Services.BookAnexoServices
{
    public static class BookAnexoGetAllPaginaService
    {
        public static async Task<List<BookAnexo>> GetAllPaginateAsync(
            this DbAppContextFVUDB_TESTE ctx)
        {
            return await ctx.BookAnexo.ToListAsync();
        }

    }
}