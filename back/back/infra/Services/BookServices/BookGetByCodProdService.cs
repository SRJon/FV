using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using back.data.entities.BookAmostra;
using back.infra.Data.Context;
using Microsoft.EntityFrameworkCore;

namespace back.infra.Services.BookServices
{
    public static class BookGetByCodProdService
    {
        public static Task<Book> GetByCodProdService(this DbAppContextFVUDB_TESTE ctx, int codProd) => ctx.Book.FirstOrDefaultAsync(x => x.CodProd == codProd);
    }
}