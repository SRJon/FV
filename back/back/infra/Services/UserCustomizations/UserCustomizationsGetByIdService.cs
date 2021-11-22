using System.Threading.Tasks;
using back.data.entities.UserCustomizations;
using back.infra.Data.Context;
using Microsoft.EntityFrameworkCore;

namespace back.infra.Services.UserCustomizationsServices
{
    public static class UserCustomizationsGetByIdService
    {
        public static Task<UserCustomizations> GetByIdService(this DbAppContextFVUDB_TESTE ctx, int id) => ctx.UserCustomizations.FirstOrDefaultAsync(x => x.Id == id);
    }
}