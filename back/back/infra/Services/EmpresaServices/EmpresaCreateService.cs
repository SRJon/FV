using System.Threading.Tasks;
using back.data.entities.Enterprise;
using back.infra.Data.Context;

namespace back.infra.Services.EmpresaServices
{
    public static class EmpresaCreateService
    {

        public static Task<bool> Create(this DbAppContextFVUDB_TESTE ctx, Empresa empresa)
        {


            ctx.Empresa.Add(empresa);
            var result = ctx.SaveChanges();


            return result > 0 ? Task.FromResult(true) : Task.FromResult(false);

        }

    }
}