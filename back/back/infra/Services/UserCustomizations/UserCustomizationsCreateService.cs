using System.Threading.Tasks;
using back.data.entities.UserCustomizations;
using back.infra.Data.Context;

namespace back.infra.Services.UserCustomizationsServices
{
    public static class UserCustomizationsCreateService
    {
        public static Task<bool> Create(this DbAppContextFVUDB_TESTE ctx, UserCustomizations UserCustomizations)
        {
            ctx.UserCustomizations.Add(UserCustomizations);
            var result = ctx.SaveChanges();
            return result > 0 ? Task.FromResult(true) : Task.FromResult(false);

        }

    }
}