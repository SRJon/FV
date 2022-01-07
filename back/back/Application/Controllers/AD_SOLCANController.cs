using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using AutoMapper;
using back.data.http;
using back.domain.DTO.AD_SOLCAN;
using back.domain.DTO.View_AD_PEDDTO;
using back.domain.entities;
using back.domain.Repositories;
using back.infra.Services.Authentication;
using back.MappingConfig;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Net.Http.Headers;

namespace back.Application.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AD_SOLCANController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly IAD_SOLCANRepository _SOLCANRepository;
        private readonly IAD_STATUSRepository _STATUSRepository;
        private readonly IAD_PEDRepository _PEDRepository;
        private readonly IUserRepository _UserRepository;

        public AD_SOLCANController(IUserRepository userRepository, IAD_SOLCANRepository sOLCANRepository, IAD_PEDRepository aD_PEDRepository, IAD_STATUSRepository aD_STATUSRepository)
        {
            _UserRepository = userRepository;
            _mapper = MapperConfig.MapperConfiguration().CreateMapper();
            _SOLCANRepository = sOLCANRepository;
            _PEDRepository = aD_PEDRepository;
            _STATUSRepository = aD_STATUSRepository;
        }

        [HttpGet]
        [Authorize]
        [Route("GetAllPedidos")]
        public async Task<ActionResult<IResponse<List<AD_SOLCANDTO>>>> GetAllDevolucao(int page = 1, int limit = 10)
        {
            string token = "";
            var authorization = Request.Headers[HeaderNames.Authorization];
            if (AuthenticationHeaderValue.TryParse(authorization, out var headerValue))
            {
                token = headerValue.Parameter;
            }
            var id = TokenService.getIdByToken(token);
            var user = await _UserRepository.GetById(id);

            var response = new Response<List<AD_SOLCANDTO>>();
            try
            {
                var result = await _SOLCANRepository.GetAllPaginateAsync(Convert.ToInt16(user.VendedorUCod), page, limit);
                response.SetConfig(200);
                response.Data = result.Data;
            }
            catch (System.Exception)
            {
                response.SetConfig(400, "Erro ao buscar SOLCAN", false);
            }
            return response.GetResponse();
        }

        [HttpGet]
        [Authorize]
        [Route("GetByNuNota")]
        public async Task<ActionResult<IResponse<AD_SOLCANDTO>>> GetById(int NuNota)
        {
            var response = new Response<AD_SOLCANDTO>();
            try
            {
                AD_SOLCANDTO result = await this._SOLCANRepository.GetByNuNota(NuNota);
                if (result != null)
                {
                    response.SetConfig(200);
                    response.Data = result;
                }
                else
                {
                    response.SetConfig(404, "SOLCAN não encontrado", false);
                }
            }
            catch (System.Exception e)
            {
                response.SetConfig(400, "Erro ao buscar SOLCAN " + e.Message, false);
            }
            return response.GetResponse();
        }
        [HttpPost]
        [Authorize]
        [Route("PostCancelamento")]
        public async Task<ActionResult<IResponse<AD_PEDFaturadoDTO>>> GetCancelamento(AD_SOLCANPropostaDTO solcanProposta)
        {
            var response = new Response<AD_PEDFaturadoDTO>();
            bool faturado = false;
            try
            {
                faturado = await this._STATUSRepository.GetFaturado(solcanProposta.NuNota);
                if (faturado)
                {
                    AD_PEDFaturadoDTO AD_PED = _mapper.Map<AD_PEDFaturadoDTO>(await this._PEDRepository.GetByNuNota(solcanProposta.NuNota));
                    response.Data = AD_PED;
                    response.SetConfig(200);
                }
            }
            catch (System.Exception e)
            {
                response.SetConfig(400, "Erro ao buscar SOLCAN " + e.Message, false);
            }
            return response.GetResponse();
        }
    }
}