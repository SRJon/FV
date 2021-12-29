using System.Threading.Tasks;
using back.data.entities.BookAnexoAmostra;
using back.infra.Data.Context;

namespace back.infra.Services.BookAnexoServices
{
    public static class BookAnexoCreateService
    {
        public static Task<bool> Create(this DbAppContextFVUDB_TESTE ctx, BookAnexo BookAnexo)
        {
            ctx.BookAnexo.Add(BookAnexo);
            var result = ctx.SaveChanges();
            return result > 0 ? Task.FromResult(true) : Task.FromResult(false);

        }

    }
}