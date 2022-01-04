using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using AutoMapper;
using back.data.http;
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
    public class AD_PEDController : ControllerBase
    {
        private readonly IUserRepository _UserRepository;
        private readonly IAD_PEDRepository _PEDRepository;
        private readonly IMapper _mapper;

        public AD_PEDController(IUserRepository userRepository, IAD_PEDRepository pEDRepository)
        {
            _UserRepository = userRepository;
            _PEDRepository = pEDRepository;
            _mapper = MapperConfig.MapperConfiguration().CreateMapper();
        }


        [HttpGet]
        [Authorize]
        [Route("GetAllPedidos")]
        public async Task<ActionResult<IResponse<List<AD_PEDPedidoDTO>>>> GetAllDevolucao(string pesquisa, int page = 1, int limit = 10)
        {
            string token = "";
            var authorization = Request.Headers[HeaderNames.Authorization];
            if (AuthenticationHeaderValue.TryParse(authorization, out var headerValue))
            {
                token = headerValue.Parameter;
            }
            var id = TokenService.getIdByToken(token);
            var user = await _UserRepository.GetById(id);

            var response = new Response<List<AD_PEDPedidoDTO>>();
            try
            {
                var result = await _PEDRepository.GetAllPaginateAsync(Convert.ToInt16(user.VendedorUCod), pesquisa, page, limit);
                response.SetConfig(200);
                response.Data = result.Data;
            }
            catch (System.Exception)
            {
                response.SetConfig(400, "Erro ao buscar Pedido", false);
            }
            return response.GetResponse();
        }

        [HttpGet]
        [Authorize]
        [Route("GetByPedidoId")]
        public async Task<ActionResult<IResponse<AD_PEDDTO>>> GetById(int id)
        {
            var response = new Response<AD_PEDDTO>();
            try
            {
                AD_PEDDTO result = await this._PEDRepository.GetByPedidoId(id);
                if (result != null)
                {
                    response.SetConfig(200);
                    response.Data = result;
                }
                else
                {
                    response.SetConfig(404, "Pedido não encontrado", false);
                }
            }
            catch (System.Exception e)
            {
                response.SetConfig(400, "Erro ao buscar pedido " + e.Message, false);
            }
            return response.GetResponse();
        }

    }

}