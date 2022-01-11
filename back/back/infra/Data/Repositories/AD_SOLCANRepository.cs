using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using back.data.converters;
using back.data.entities.AD_SOLCANota;
using back.data.http;
using back.domain.DTO.AD_SOLCAN;
using back.domain.DTO.AD_STATUS;
using back.domain.Repositories;
using back.infra.Data.Context;
using back.infra.Services.AD_SOLCANServices;
using back.MappingConfig;
using Microsoft.EntityFrameworkCore;

namespace back.infra.Data.Repositories
{

    /// <summary>
    /// Repositório de SOLCAN(Solicitação de cancelamento)
    /// Onde é realizada todas as chamadas dos services.
    /// </summary>


    public class AD_SOLCANRepository : ValidPagination, IAD_SOLCANRepository
    {
        private readonly IMapper _mapper;
        private readonly DbContexts _ctxs;

        /// <summary>
        /// Construtor padrão de SOLCAN
        /// </summary>
        /// <param name="mapper">Entidade mapper, responsável pelos mapeamentos da entidade SOLCAN e os DTOS de SOLCAN</param>
        /// <param name="ctxs">Contexto do banco de dados</param>
        public AD_SOLCANRepository(IMapper mapper, DbContexts ctxs)
        {
            _mapper = MapperConfig.MapperConfiguration().CreateMapper();
            _ctxs = ctxs;
        }

        /// <summary>
        /// Get all SOLCAN, relacionado ao código do vendedor(codven) do usuário logado
        /// </summary>
        /// <param name="codVend">Código do vendedor relacionado ao usuário logado</param>
        /// <param name="page">página atual</param>
        /// <param name="limit">limite de itens por página</param>
        /// <returns>List de SOLCAN</returns>
        public async Task<Response<List<AD_SOLCANDTO>>> GetAllPaginateAsync(int codVend, int page, int limit)
        {
            var response = new Response<List<AD_SOLCANDTO>>();
            var contexto = _ctxs.GetSankhya();
            try
            {

                base.ValidPaginate(page, limit);
                var savedSearchesConsulta = contexto.AD_SOLCAN.Where(p => p.CodVend == codVend).Take(int.MaxValue);

                List<AD_SOLCANDTO> dTOs = new List<AD_SOLCANDTO>();

                var savedSearches = savedSearchesConsulta.Skip(base.skip).OrderBy(o => o.NuNota).Take(base.limit);
                var parceiros = await savedSearches.ToListAsync();
                parceiros.ForEach(e => dTOs.Add(_mapper.Map<AD_SOLCANDTO>(e)));

                response.Data = dTOs;
                response.TotalPages = await savedSearchesConsulta.CountAsync();
                response.Page = page;
                response.TotalPages = base.getTotalPages(response.TotalPages);
                response.Success = true;
                response.StatusCode = 200;
                return response;

            }
            catch (System.Exception e)
            {

                response.StatusCode = 400;
                response.Message = e.Message;
                return response;
            }
        }

        /// <summary>
        /// Criador de SOLCAN
        /// </summary>
        /// <param name="solcanCreate">SOLCAN a ser criado</param>
        /// <returns>bool</returns>
        public Task<bool> CreateSolcan(AD_SOLCANCreateDTO solcanCreate)
        {
            try
            {
                var result = _ctxs.GetSankhya().Create(solcanCreate);
                return result;
            }
            catch (System.Exception)
            {
                return Task.FromResult(false);
            }

        }

        /// <summary>
        /// Get de SOLCAN buscando via NuNota
        /// </summary>
        /// <param name="NuNota">NuNota da SOLCAN</param>
        /// <returns>SOLCAN</returns>
        public async Task<AD_SOLCANDTO> GetByNuNota(int NuNota)
        {
            return _mapper.Map<AD_SOLCANDTO>(await this._ctxs.
            GetSankhya()
            .GetByNuNotaService(NuNota));
        }


        /// <summary>
        /// Verificação se razão de cancelamento é válida, segunda regra de negócio somente Preço Menor "PM" é uma razão válida para uma proposta
        /// </summary>
        /// <param name="reason">Motivo do cancelamento</param>
        /// <returns>bool</returns>
        public bool ValidCancelRequest(string reason)
        {
            bool isValid = false;

            if (reason != "PM" || reason != "")
                isValid = true;

            return isValid;
        }

        /// <summary>
        /// Verificação se há solicitação de cancelamento aberto para aquela NuNota
        /// Se já houver, ele não abrirá novamente.
        /// </summary>
        /// <param name="NuNota">NuNota</param>
        /// <returns>bool</returns>
        public async Task<bool> CancelRequistExistsAsync(int NuNota)
        {
            var cancelamento = _mapper.Map<AD_SOLCANDTO>(await this._ctxs.
            GetSankhya()
            .GetByNuNotaService(NuNota));
            return cancelamento != null ? true : false;
        }
    }
}