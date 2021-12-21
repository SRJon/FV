using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using back.data.entities.BookAnexoAmostra;
using back.infra.Data.Context;
using Microsoft.EntityFrameworkCore;

namespace back.infra.Services.BookAnexoServices
{
    public static class BookAnexoGetByCodProService
    {
        public static Task<BookAnexo> GetBycodProdService(this DbAppContextFVUDB_TESTE ctx, int codProd) => ctx.BookAnexo.Include(u => u.book).FirstOrDefaultAsync(x => x.CodProd == codProd);
    }
}