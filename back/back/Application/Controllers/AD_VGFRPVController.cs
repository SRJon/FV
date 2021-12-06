using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using AutoMapper;
using back.data.entities.VIEW_AD_VGFRPV;
using back.data.http;
using back.domain.DTO.AD_VGFRPVDTO;
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
    public class AD_VGFRPVController : ControllerBase
    {

        private readonly IMapper _mapper;
        private readonly IAD_VGFRPVRepository _AD_VGFRPVRepository;
        private readonly IUserRepository _UserRepository;
        private readonly IAD_SALDO_PARCEIRORepository _IAD_SALDO_PARCEIRORepository;

        public AD_VGFRPVController(IAD_VGFRPVRepository AD_VGFRPVRepository, IUserRepository UserRepository, IAD_SALDO_PARCEIRORepository AD_SALDO_PARCEIRORepository)
        {
            _mapper = MapperConfig.MapperConfiguration().CreateMapper();
            _AD_VGFRPVRepository = AD_VGFRPVRepository;
            _UserRepository = UserRepository;
            _IAD_SALDO_PARCEIRORepository = AD_SALDO_PARCEIRORepository;
        }

        [HttpGet]
        [Authorize]
        public async Task<ActionResult<IResponse<List<AD_VGFRPVSaldoDTO>>>> GetAllAsync([FromQuery] AD_VGFRPVGetAllEntity payload)
        {
            string token = "";
            var authorization = Request.Headers[HeaderNames.Authorization];
            if (AuthenticationHeaderValue.TryParse(authorization, out var headerValue))
            {
                token = headerValue.Parameter;
            }
            var id = TokenService.getIdByToken(token);
            var user = await _UserRepository.GetById(id);


            var response = new Response<List<AD_VGFRPVSaldoDTO>>();
            try
            {
                if (user != null)
                {
                    var result = await _AD_VGFRPVRepository.GetAllPaginateAsync(payload.page, payload.limit, (int)user.VendedorUCod);
                    foreach (var parceiro in result.Data)
                    {
                        var saldoCredito = await this._IAD_SALDO_PARCEIRORepository.GetById(parceiro.Codparc);
                        parceiro.Saldo = saldoCredito.Saldo;
                        parceiro.LimCred = saldoCredito.LimCred;
                    }
                    response.SetConfig(200);
                    response.Data = result.Data;
                    response.setHttpAtr(result);
                }
                else
                {
                    response.SetConfig(400, "Não há vendedor associado ao usuário - AD_VGFRPVs", false);
                }
            }
            catch (System.Exception)
            {
                response.SetConfig(404, "Erro ao buscar as AD_VGFRPVs", false);
            }
            return response.GetResponse();
        }

        //TODO COLOCAR CODPARC
        [HttpGet]
        [Authorize]
        [Route("GetByIdVend")]
        public async Task<ActionResult<IResponse<AD_VGFRPVDTO>>> getById(Int16 codVend)
        {
            var response = new Response<AD_VGFRPVDTO>();

            try
            {
                var result = await this._AD_VGFRPVRepository.GetById(codVend);
                if (result != null)
                {
                    response.SetConfig(200);
                    response.Data = result;
                }
                else
                {
                    response.SetConfig(404, "AD_VGFRPV não encontrado", false);
                }
            }
            catch (System.Exception)
            {
                response.SetConfig(400, "Erro ao buscar a AD_VGFRPV", false);
            }
            return response.GetResponse();
        }
        [HttpGet]
        [Authorize]
        [Route("GetByIdParc")]

        public async Task<ActionResult<IResponse<AD_VGFRPVDTO>>> getById(int codParc)
        {
            var response = new Response<AD_VGFRPVDTO>();

            try
            {
                var result = await this._AD_VGFRPVRepository.GetById(codParc);
                if (result != null)
                {
                    response.SetConfig(200);
                    response.Data = result;
                }
                else
                {
                    response.SetConfig(404, "AD_VGFRPV não encontrado", false);
                }
            }
            catch (System.Exception)
            {
                response.SetConfig(400, "Erro ao buscar a AD_VGFRPV", false);
            }
            return response.GetResponse();
        }
    }
}