using AutoMapper;
using back.data.entities.Screen;
using back.domain.DTO.ScreenDTO;
using back.infra.Data.Context;
using back.MappingConfig;
using System.Threading.Tasks;

namespace back.infra.Services.TelaServices
{
    public static class ScreenCreateService
    {
        private static readonly IMapper _mapper = MapperConfig.MapperConfiguration().CreateMapper();
        
        public static Task<bool> Create(this DbAppContextFVUDB_TESTE ctx, TelaDTOCreate tela)
        {
            ctx.Tela.Add(_mapper.Map<Tela>(tela));
            var result = ctx.SaveChanges();
            return result > 0 ? Task.FromResult(true) : Task.FromResult(false);
        }

    }
}