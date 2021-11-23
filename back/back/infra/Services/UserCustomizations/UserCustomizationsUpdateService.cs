using System.Threading.Tasks;
using back.domain.DTO.UserCustomizations;
using back.infra.Data.Context;

namespace back.infra.Services.UserCustomizationsServices
{
    public static class UserCustomizationsUpdateService
    {
        public static async Task<bool> UpdateUserCustomizationsServices(this DbAppContextFVUDB_TESTE ctx, UserCustomizationsDTOUpdateDTO UserCustomizations, int id)
        {
            var toUpdate = await ctx.GetByIdService(id);
            ctx.Entry(toUpdate).CurrentValues.SetValues(UserCustomizations);
            var result = ctx.SaveChanges();
            return result > 0 ? true : false;
        }
    }
}