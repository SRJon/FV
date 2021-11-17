using System.Threading.Tasks;
using AutoMapper;
using back.data.entities.ProfileScreen;
using back.domain.DTO.ProfileScreenDTO;
using back.infra.Data.Context;
using back.MappingConfig;

namespace back.infra.Services.PerfilTelaServices
{
    public static class ProfileScreenCreateService
    {
        private static readonly IMapper _mapper = MapperConfig.MapperConfiguration().CreateMapper();
        public static Task<bool> Create(this DbAppContextFVUDB_TESTE ctx, PerfilTelaDTOCreate perfilTela)
        {
            ctx.PerfilTela.Add(_mapper.Map<PerfilTela>(perfilTela));
            var result = ctx.SaveChanges();
            return result > 0 ? Task.FromResult(true) : Task.FromResult(false);
        }
    }
}