using System.Threading.Tasks;
using AutoMapper;
using back.data.entities.User;
using back.domain.DTO.Usuario;
using back.infra.Data.Context;
using back.infra.Services.Authentication;
using back.MappingConfig;

namespace back.infra.Services.UsuarioServices
{
    public static class UsuarioCreateService
    {
        private static readonly IMapper _mapper = MapperConfig.MapperConfiguration().CreateMapper();

        public static Task<bool> Create(this DbAppContextFVUDB_TESTE ctx, UsuarioDTOCreate usuario)
        {
            try
            {
                usuario.SenhaFV = PasswordHash.HashPassword(usuario.Senha);
                ctx.Usuario.Add(_mapper.Map<Usuario>(usuario));
                var result = ctx.SaveChanges();
                return result > 0 ? Task.FromResult(true) : Task.FromResult(false);
            }
            catch (System.Exception e)
            {

                throw e;
            }

        }

    }
}