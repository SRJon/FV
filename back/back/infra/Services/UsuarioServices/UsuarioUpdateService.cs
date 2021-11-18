using System.Threading.Tasks;
using back.infra.Data.Context;
using back.domain.DTO.Usuario;


namespace back.infra.Services.UsuarioServices

{
    public static class UsuarioUpdateService
    {
        public static async Task<bool> UpdateUsuarioService(this DbAppContextFVUDB_TESTE contexto, UsuarioDTOUpdateDTO usuario, int id)
        {
            var toUpdate = await contexto.GetByIdUserService(id);
            contexto.Entry(toUpdate).CurrentValues.SetValues(usuario);
            var result = contexto.SaveChanges();

            return result > 0 ? true : false;
        }
    }
}