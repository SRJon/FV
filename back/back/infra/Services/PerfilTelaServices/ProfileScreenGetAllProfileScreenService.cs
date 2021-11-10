using System.Collections.Generic;
using System.Threading.Tasks;
using back.data.entities.ProfileScreen;
using back.infra.Data.Context;
using Microsoft.EntityFrameworkCore;

namespace back.infra.Services.PerfilTelaServices
{
    public static class ProfileScreenGetAllProfileScreenService
    {
        public static async Task<List<PerfilTela>> GetAllPaginateAsync(
            this DbAppContextFVUDB_TESTE ctx)
        {
            return await ctx.PerfilTela.ToListAsync();
        }
    }
}