using System.Threading.Tasks;
using AutoMapper;
using back.data.entities.Profile;
using back.domain.DTO.ProfileDTO;
using back.infra.Data.Context;
using back.MappingConfig;

namespace back.infra.Services.PerfilServices
{
    public static class ProfileCreateService
    {
        private static readonly IMapper _mapper = MapperConfig.MapperConfiguration().CreateMapper();
        public static Task<bool> Create(this DbAppContextFVUDB_TESTE ctx, PerfilDTOCreate perfil)
        {
            ctx.Perfil.Add(_mapper.Map<Perfil>(perfil));
            var result = ctx.SaveChanges();
            return result > 0 ? Task.FromResult(true) : Task.FromResult(false);
        }
    }

}