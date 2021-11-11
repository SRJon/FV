using System.Collections.Generic;
using System.Threading.Tasks;
using back.data.entities.Profile;
using back.infra.Data.Context;
using Microsoft.EntityFrameworkCore;

namespace back.infra.Services.PerfilServices
{
    public static class ProfileGetAllPerfilService
    {
        public static async Task<List<Perfil>> GetAllPerfilAsync(this DbAppContextFVUDB_TESTE ctx)
        {
            return await ctx.Perfil.ToListAsync();
        }
    }
}