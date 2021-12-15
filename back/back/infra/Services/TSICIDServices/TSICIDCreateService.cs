using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using back.data.entities.TSICidade;
using back.domain.DTO.TSICidadeDTO;
using back.infra.Data.Context;
using back.infra.Data.Utils;
using back.MappingConfig;

namespace back.infra.Services.TSICIDServices
{
    public static class TSICIDCreateService
    {
        private static readonly IMapper _mapper = MapperConfig.MapperConfiguration().CreateMapper();
        public static async Task<bool> Create(this DbAppContextSankhya ctx, TSICIDDTOCreate tsicid)
        {
            var json = tsicid.ProductEntityToJson("Cidade");

            var result = await APISankhya.SankhyaCRUDPostAsync(json);
            var resposta = result.Substring(result.IndexOf(":", 22) + 2, 1);
            return resposta == "1" ? (true) : (false);
        }
    }
}