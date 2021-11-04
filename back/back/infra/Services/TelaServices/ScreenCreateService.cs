using back.data.entities.Screen;
using back.infra.Data.Context;
using System.Threading.Tasks;

namespace back.infra.Services.TelaServices
{
    public static class ScreenCreateService
    {


        public static Task<bool> Create(this DbAppContextFVUDB_TESTE ctx,Tela tela)
        {

 
            ctx.Tela.Add(tela);
            var result = ctx.SaveChanges();


            return result > 0 ? Task.FromResult(true) : Task.FromResult(false);

        }

    }
}