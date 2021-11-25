using System.Threading.Tasks;
using back.domain.DTO.BookAnexo;
using back.infra.Data.Context;

namespace back.infra.Services.BookAnexoServices
{
    public static class BookAnexoUpdateService
    {
        public static async Task<bool> UpdateBookAnexoServices(this DbAppContextFVUDB_TESTE ctx, BookAnexoDTOUpdateDTO BookAnexo, int id)
        {
            var toUpdate = await ctx.GetByIdService(id);
            ctx.Entry(toUpdate).CurrentValues.SetValues(BookAnexo);
            var result = ctx.SaveChanges();
            return result > 0 ? true : false;
        }
    }
}