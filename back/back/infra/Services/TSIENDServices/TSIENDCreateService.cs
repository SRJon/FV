using System.Threading.Tasks;
using AutoMapper;
using back.data.entities.TSIEndereco;
using back.domain.DTO.TSIEnderecoDTO;
using back.infra.Data.Context;
using back.MappingConfig;

namespace back.infra.Services.TSIENDServices
{
    public static class TSIENDCreateService
    {
        private static readonly IMapper _mapper = MapperConfig.MapperConfiguration().CreateMapper();
        public static Task<bool> Create(this DbAppContextSankhya ctx, TSIENDDTOCreate tsiend)
        {
            ctx.TSIEND.Add(_mapper.Map<TSIEND>(tsiend));
            var result = ctx.SaveChanges();
            return result > 0 ? Task.FromResult(true) : Task.FromResult(false);
        }
    }
}