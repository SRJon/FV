using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using back.data.http;
using back.domain.DTO.TGFFinanceiroDTO;
using back.domain.entities;
using back.domain.Repositories;
using back.MappingConfig;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace back.Application.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TGFFINController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly ITGFFINRepository _TGFFINRepository;

        public TGFFINController(ITGFFINRepository tGFFINRepository)
        {
            _mapper = MapperConfig.MapperConfiguration().CreateMapper();
            _TGFFINRepository = tGFFINRepository;
        }

        [HttpGet]
        [Authorize]
        [Route("GetByIdFinanceiro")]
        public async Task<ActionResult<IResponse<TGFFINClienteDTO>>> GetByIdNF(int nufin)
        {
            var response = new Response<TGFFINClienteDTO>();
            try
            {
                TGFFINClienteDTO result = await this._TGFFINRepository.GetByIdFinanceiro(nufin);
                if (result != null)
                {
                    response.SetConfig(200);
                    response.Data = result;
                }
                else
                {
                    response.SetConfig(404, "Financeiro não encontrado", false);
                }
            }
            catch (System.Exception e)
            {
                response.SetConfig(400, "Erro ao buscar financeiro " + e.Message, false);
            }
            return response.GetResponse();
        }
        [HttpGet]
        [Authorize]
        [Route("GetByNumNotaFinanceiro")]
        public async Task<ActionResult<IResponse<TGFFINClienteDTO>>> GetByNumnota(int numnota)
        {
            var response = new Response<TGFFINClienteDTO>();
            try
            {
                TGFFINClienteDTO result = await this._TGFFINRepository.GetByIDNumnota(numnota);
                if (result != null)
                {
                    response.SetConfig(200);
                    response.Data = result;
                }
                else
                {
                    response.SetConfig(404, "Financeiro não encontrado", false);
                }
            }
            catch (System.Exception e)
            {
                response.SetConfig(400, "Erro ao buscar financeiro " + e.Message, false);
            }
            return response.GetResponse();
        }
        [HttpGet]
        [Authorize]
        [Route("GetAllFinanceiro")]
        public async Task<ActionResult<IResponse<List<TGFFINClienteDTO>>>> GetAllNF(int codParc, int page = 1, int limit = 10)
        {
            var response = new Response<List<TGFFINClienteDTO>>();

            try
            {

                var result = await _TGFFINRepository.GetAllFinanceiroPaginateAsync(page, limit, codParc);
                response.SetConfig(200);
                response.Data = result.Data;
            }
            catch (System.Exception)
            {
                response.SetConfig(400, "Erro ao buscar TGFCAB", false);
            }
            return response.GetResponse();
        }
    }
}