using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using back.data.entities.TSIEndereco;
using back.domain.DTO.TSIEnderecoDTO;
using back.infra.Data.Context;
using back.infra.Data.Utils;
using back.MappingConfig;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;

namespace back.infra.Services.TSIENDServices
{
    public static class TSIENDCreateService
    {
        private static readonly IMapper _mapper = MapperConfig.MapperConfiguration().CreateMapper();
        public static async Task<bool> Create(this DbAppContextSankhya ctx, TSIENDDTOCreate tsiend)
        {
            var json = tsiend.ProductEntityToJson("Endereco");

            var result = await APISankhya.SankhyaCRUDPostAsync(json);
            var resposta = result.Substring(result.IndexOf(":", 22) + 2, 1);
            return resposta == "1" ? (true) : (false);
        }
    }
}