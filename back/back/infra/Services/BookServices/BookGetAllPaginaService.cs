using System.Collections.Generic;
using System.Threading.Tasks;
using back.data.entities.BookAmostra;
using back.infra.Data.Context;
using Microsoft.EntityFrameworkCore;

namespace back.infra.Services.BookServices
{
    public static class BookAnexoGetAllPaginaService
    {
        public static async Task<List<Book>> GetAllPaginateAsync(
            this DbAppContextFVUDB_TESTE ctx)
        {
            return await ctx.Book.ToListAsync();
        }

    }
}