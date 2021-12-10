using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using back.data.entities.TSIBairro;
using back.domain.DTO.TSIBairroDTO;
using back.infra.Data.Context;
using back.infra.Data.Utils;
using back.MappingConfig;

namespace back.infra.Services.TSIBAIServices
{
    public static class TSIBAICreateService
    {
        private static readonly IMapper _mapper = MapperConfig.MapperConfiguration().CreateMapper();

        public static async Task<bool> Create(this DbAppContextSankhya ctx, TSIBAIDTOCreate tsibai)
        {
            var json = tsibai.ProductEntityToJson("Bairro");

            var result = await APISankhya.SankhyaCRUDPostAsync(json);
            var resposta = result.Substring(result.IndexOf(":", 22) + 2, 1);
            return resposta == "1" ? (true) : (false);
        }
    }
}