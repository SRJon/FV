using System.Threading.Tasks;
using back.data.entities.Enterprise;
using back.infra.Data.Context;
using Microsoft.EntityFrameworkCore;

namespace back.infra.Services.EmpresaServices
{
    public static class EmpresaGetByIdService
    {
        public static Task<Empresa> GetByIdService(this DbAppContextFVUDB_TESTE ctx, int id) => ctx.Empresa.FirstOrDefaultAsync(x => x.Id == id);
    }
}