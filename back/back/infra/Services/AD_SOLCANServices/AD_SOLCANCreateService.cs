using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using back.data.entities.AD_SOLCANota;
using back.domain.DTO.AD_SOLCAN;
using back.infra.Data.Context;
using back.MappingConfig;

namespace back.infra.Services.AD_SOLCANServices
{
    /// <summary>
    /// Clase de serviço de AD_SOLCAN que cria uma nova solicitação de cancelamento no banco de dados do Sankhya.
    /// </summary>
    public static class AD_SOLCANCreateService
    {
        private static readonly IMapper _mapper = MapperConfig.MapperConfiguration().CreateMapper();

        /// <summary>
        /// Função que cria o AD_SOLCAN no Sankhya
        /// </summary>
        /// <param name="ctx">Contexo do banco de dados</param>
        /// <param name="solcanCreate">Solicitação de Cancelamento a ser criada</param>
        /// <returns>bool</returns>
        public static Task<bool> Create(this DbAppContextSankhya ctx, AD_SOLCANCreateDTO solcanCreate)
        {
            ctx.AD_SOLCAN.Add(_mapper.Map<AD_SOLCAN>(solcanCreate));
            var result = ctx.SaveChanges();
            return result > 0 ? Task.FromResult(true) : Task.FromResult(false);
        }


    }
}