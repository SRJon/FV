using System.Threading.Tasks;
using AutoMapper;
using back.data.entities.TGFContato;
using back.domain.DTO.TGFParceiroDTO;
using back.infra.Data.Context;
using back.MappingConfig;

namespace back.infra.Services.TGFPARServices
{
    public static class TGFPARCreateClientService
    {
        private static readonly IMapper _mapper = MapperConfig.MapperConfiguration().CreateMapper();
        public static Task<bool> Create(this DbAppContextSankhya ctx, TGFPARDTOCreate cliente)
        {
            ctx.TGFCTT.Add(_mapper.Map<TGFCTT>(cliente));
            var result = ctx.SaveChanges();

            return result > 0 ? Task.FromResult(true) : Task.FromResult(false);
        }
    }
}