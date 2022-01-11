using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using AutoMapper;
using back.data.http;
using back.domain.DTO.AD_PEDIDOCANCELAMENTO;
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
    /// <summary>
    /// Controller da View AD_PED (Simplificação da tela Representante-> Pedidos)
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class AD_PEDController : ControllerBase
    {
        private readonly IUserRepository _UserRepository;
        private readonly IAD_PEDRepository _PEDRepository;
        private readonly IAD_PEDIDOCANCELAMENTORepository _PEDIDOCANCELAMENTORepository;
        private readonly IMapper _mapper;
        /// <summary>
        /// Construtor padrão do controller
        /// </summary>
        /// <param name="userRepository">Repositório de usuário</param>
        /// <param name="pEDRepository">Repositório de PED</param>
        /// <param name="aD_STATUSRepository">Repositório de STATUS</param>
        /// <param name="aD_SOLCANRepository">Repositório de SOLCAN</param>
        /// <param name="_ADPEDIDOCANCELAMENTORepository">Repositório da view pedido cancelamento</param>
        public AD_PEDController(IUserRepository userRepository, IAD_PEDRepository pEDRepository, IAD_STATUSRepository aD_STATUSRepository, IAD_SOLCANRepository aD_SOLCANRepository, IAD_PEDIDOCANCELAMENTORepository _ADPEDIDOCANCELAMENTORepository)
        {
            _UserRepository = userRepository;
            _PEDRepository = pEDRepository;
            _PEDIDOCANCELAMENTORepository = _ADPEDIDOCANCELAMENTORepository;

            _mapper = MapperConfig.MapperConfiguration().CreateMapper();
        }



        /// <summary>
        /// Get all da view AD_PED puxando somente pedidos relacionados ao vendedor logado.
        /// Permite busca de por notaNumNota(int), nomeparc(string), vlrpedido(double) e adStatus(string), todos no mesmo campo do front
        /// </summary>
        /// <param name="pesquisa">Campo que diminui a lista de itens</param>
        /// <param name="page">pagina atual</param>
        /// <param name="limit">itens por página</param>
        /// <returns></returns>
        [HttpGet]
        [Authorize]
        [Route("GetAllPedidos")]
        public async Task<ActionResult<IResponse<List<AD_PEDPedidoDTO>>>> GetAllPedido(string pesquisa, int page = 1, int limit = 10)
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
        /// <summary>
        /// Get all da view AD_PED puxando somente pedidos relacionados ao vendedor logado.
        /// Permite busca de por notaNumNota(int), nomeparc(string), vlrpedido(double) e adStatus(string), todos no mesmo campo do front
        /// </summary>
        /// <param name="pesquisa">Campo que diminui a lista de itens</param>
        /// <param name="page">pagina atual</param>
        /// <param name="limit">itens por página</param>
        /// <returns></returns>
        [HttpGet]
        [Authorize]
        [Route("GetAllPedidosCancelamento")]
        public async Task<ActionResult<IResponse<List<AD_PEDIDOCANCELAMENTODTO>>>> GetAllPedidoCancelamento(string pesquisa, int page = 1, int limit = 10)
        {
            string token = "";
            var authorization = Request.Headers[HeaderNames.Authorization];
            if (AuthenticationHeaderValue.TryParse(authorization, out var headerValue))
            {
                token = headerValue.Parameter;
            }
            var id = TokenService.getIdByToken(token);
            var user = await _UserRepository.GetById(id);

            var response = new Response<List<AD_PEDIDOCANCELAMENTODTO>>();
            try
            {
                var result = await _PEDIDOCANCELAMENTORepository.GetAllPaginateAsync(Convert.ToInt16(user.VendedorUCod), pesquisa, page, limit);
                response.SetConfig(200);
                response.Data = result.Data;
            }
            catch (System.Exception)
            {
                response.SetConfig(400, "Erro ao buscar Pedido", false);
            }
            return response.GetResponse();
        }

        /// <summary>
        /// Get pedido por pedidoID
        /// </summary>
        /// <param name="id">pedidoId a ser buscada</param>
        /// <returns></returns>
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