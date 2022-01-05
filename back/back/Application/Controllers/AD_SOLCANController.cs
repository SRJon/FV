using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using AutoMapper;
using back.data.http;
using back.domain.DTO.AD_SOLCAN;
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
        private readonly IUserRepository _UserRepository;

        public AD_SOLCANController(IUserRepository userRepository, IAD_SOLCANRepository sOLCANRepository)
        {
            _UserRepository = userRepository;
            _mapper = MapperConfig.MapperConfiguration().CreateMapper();
            _SOLCANRepository = sOLCANRepository;
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
    }
}