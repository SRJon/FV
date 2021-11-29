using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using back.data.entities.TSIEndereco;
using back.domain.DTO.TSIEnderecoDTO;
using back.infra.Data.Context;
using back.MappingConfig;
using Microsoft.EntityFrameworkCore;

namespace back.infra.Services.TSIENDServices
{
    public static class TSIENDCreateService
    {
        private static readonly IMapper _mapper = MapperConfig.MapperConfiguration().CreateMapper();
        public static Task<bool> Create(this DbAppContextSankhya ctx, TSIENDDTO tsiend)
        {
            var lastId = ctx.TSIEND.FirstOrDefault(p => p.Codend == (ctx.TSIEND.Max(x => x.Codend)));
            tsiend.Codend = lastId.Codend + 1;
            ctx.TSIEND.Add(_mapper.Map<TSIEND>(tsiend));
            var result = ctx.SaveChanges();
            return result > 0 ? Task.FromResult(true) : Task.FromResult(false);
        }
    }
}