using System.Collections.Generic;
using System.Threading.Tasks;
using back.data.entities.UserCustomizations;
using back.infra.Data.Context;
using Microsoft.EntityFrameworkCore;

namespace back.infra.Services.UserCustomizationsServices
{
    public static class UserCustomizationsGetAllPaginaService
    {
        public static async Task<List<UserCustomizations>> GetAllPaginateAsync(
            this DbAppContextFVUDB_TESTE ctx)
        {
            return await ctx.UserCustomizations.ToListAsync();
        }

    }
}