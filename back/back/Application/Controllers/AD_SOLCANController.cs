using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using AutoMapper;
using back.data.entities.AD_SOLCANota;
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
    /// <summary>
    /// SOLCAN Controller - Solicitação de cancelamento - 
    /// Controller responsável pelas solicitações de cancelamento de pedido.
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class AD_SOLCANController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly IAD_SOLCANRepository _SOLCANRepository;
        private readonly IAD_STATUSRepository _STATUSRepository;
        private readonly IAD_PEDRepository _PEDRepository;
        private readonly IUserRepository _UserRepository;

        /// <summary>
        /// Construtor padrão de um solicitador de cancelamento
        /// </summary>
        /// <param name="userRepository">Repositório de usuário</param>
        /// <param name="sOLCANRepository">Repositório de SOLCAN</param>
        /// <param name="aD_PEDRepository">Repositório da View AD_PED</param>
        /// <param name="aD_STATUSRepository">Repositório de AD_STATUS</param>
        public AD_SOLCANController(IUserRepository userRepository, IAD_SOLCANRepository sOLCANRepository, IAD_PEDRepository aD_PEDRepository, IAD_STATUSRepository aD_STATUSRepository)
        {
            _UserRepository = userRepository;
            _mapper = MapperConfig.MapperConfiguration().CreateMapper();
            _SOLCANRepository = sOLCANRepository;
            _PEDRepository = aD_PEDRepository;
            _STATUSRepository = aD_STATUSRepository;
        }

        /// <summary>
        /// Função retorna todos as solicitações de cancelamentos (SOLCAN) relacionados ao usuário que está logado
        /// </summary>
        /// <param name="page">Página de exibição</param>
        /// <param name="limit">Quantidade de itens por página</param>
        /// <returns>Lista de SOLCAN </returns>
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

        /// <summary>
        /// Função que retorna a solicitação de cancelamento (SOLCAN) via nuNota
        /// </summary>
        /// <param name="NuNota">NuNota relacionado ao SOLCAN</param>
        /// <returns>SOLCAN</returns>
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

        /// <summary>
        /// Função que cria a solicitação de cancelamento relacionada a um pedido
        /// </summary>
        /// <param name="solcanProposta">DTO contendo NuNota de identificação de SOLCAN, motivo de cancelamento e proposta de preço (quando o motivo for de preço menor no mercado)</param>
        /// <returns></returns>
        [HttpPost]
        [Authorize]
        [Route("SolicitarCancelamento")]
        public async Task<ActionResult<IResponse<AD_PEDFaturadoDTO>>> CriarCancelamento(AD_SOLCANPropostaDTO solcanProposta)
        {
            var response = new Response<AD_PEDFaturadoDTO>();
            try
            {

                var isValid = await this.IsValid(solcanProposta.Motivo, solcanProposta.NuNota);
                // if (isValid.isValid)
                // {
                var pedido = await this._PEDRepository.GetByNuNota(solcanProposta.NuNota);
                if (pedido != null)
                {
                    AD_PEDDTO AD_PED = _mapper.Map<AD_PEDDTO>(pedido);
                    if ((!isValid.Faturado) || (isValid.Faturado && AD_PED.statusPed.ToUpper() != "FATURADO" && AD_PED.datafatur <= DateTime.Now))
                    {
                        var exist = await this._SOLCANRepository.CancelRequistExistsAsync(solcanProposta.NuNota);
                        if (!exist)
                        {
                            if (solcanProposta.Motivo == "PM" && solcanProposta.Proposta == "")
                            {
                                response.SetConfig(400, "Favor preencher o campo proposta", false);
                            }
                            else
                            {
                                var cancelado = await this.PedidoFaturadoValidacoes(AD_PED, isValid.Faturado, solcanProposta);
                                if (cancelado)
                                    response.SetConfig(200);
                                else
                                    response.SetConfig(400, "Solicitação não aceita", false);
                            }
                        }
                        else
                        {
                            response.SetConfig(400, "Pedido já possui solicitação de cancelamento", false);
                        }
                    }
                    else
                    {
                        response.SetConfig(400, "Pedido já foi faturado no dia " + AD_PED.datafatur.ToString() + " não pode ser solicitado o cancelamento", false);
                    }
                }
                else
                {
                    response.SetConfig(400, "Pedido não encontrado, tente novamente", false);
                }
                // }
                // else
                // {
                //     response.SetConfig(400, "Motivo inválido", false);
                // }
            }
            catch (System.Exception e)
            {
                response.SetConfig(400, "Erro ao buscar SOLCAN " + e.Message, false);
            }
            return response.GetResponse();
        }

        /// <summary>
        /// Função de verificação se o cancelamento é válido 
        /// </summary>
        /// <param name="reason">Motivo de cancelamento</param>
        /// <param name="nunota">NuNota ser buscada para verificar se já está faturada ou não</param>
        /// <returns></returns>
        protected async Task<CancelamentoFaturadoDTO> IsValid(string reason, int nunota)
        {
            bool faturado = await this._STATUSRepository.GetFaturado(nunota);
            bool isValid = this._SOLCANRepository.ValidCancelRequest(reason);
            var result = new CancelamentoFaturadoDTO();
            result.isValid = !faturado && isValid;
            result.Faturado = faturado;
            result.ValidRequisition = isValid;
            return result; ;
        }

        /// <summary>
        /// Verificações da regra de negócio da solicitação de cancelamento.
        /// Se for faturado e o statu
        /// </summary>
        /// <param name="ped">AD_PED contendo informações do pedido que será cancelado</param>
        /// <param name="faturado">Boolean que informa se o pedido já fora faturado</param>
        /// <param name="proposta">Proposta para quando o preço do mercado for menor que o da compra.</param>
        /// <returns>bool</returns>
        protected async Task<bool> PedidoFaturadoValidacoes(AD_PEDDTO ped, bool faturado, AD_SOLCANPropostaDTO proposta)
        {
            bool podeFaturar = faturado && ped.statusPed.ToUpper() != "FATURADO" && ped.datafatur <= DateTime.Now;
            bool cancelado = false;
            if (podeFaturar || !faturado)
            {
                var exist = await this._SOLCANRepository.CancelRequistExistsAsync(ped.pedNunota);

                if (!exist)
                {
                    var solcan = new AD_SOLCANCreateDTO();
                    solcan.NuNota = ped.pedNunota;
                    solcan.Motivo = ped.motvcanc;
                    solcan.DtSolicitacao = DateTime.Now;
                    solcan.DtAutorizacao = null;
                    solcan.Autorizacao = "P";
                    solcan.Proposta = proposta.Proposta;
                    solcan.CodVend = ped.codvend;
                    solcan.ContraProposta = "";
                    solcan.CodParc = ped.codparc;
                    solcan.Ad_PedidoId = ped.adPedidoid;
                    try
                    {
                        cancelado = await this._SOLCANRepository.CreateSolcan(solcan);
                    }
                    catch (System.Exception)
                    {

                        throw;
                    }
                    if (cancelado)
                    {
                        // TODO: ENVIAR UM EMAIL POS SALVAR O ITEM
                    }


                }
            }
            return cancelado;
        }
    }
}