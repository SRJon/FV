using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using AutoMapper;
using back.data.http;
using back.domain.DTO.TSIEmpDTO;
using back.domain.DTO.View_AD_DEVSOLICITACAODTO;
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
    public class AD_DEVSOLICITACAOController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly IAD_DEVSOLICITACAORepository _AD_DEVSOLICITACAO;
        private readonly IUserRepository _UserRepository;
        private readonly ITSIEMPRepository _TSIEMPRepository;

        public AD_DEVSOLICITACAOController(IAD_DEVSOLICITACAORepository aD_DEVSOLICITACAO, ITSIEMPRepository TSIEMPRepository, IUserRepository UserRepository)
        {
            _mapper = MapperConfig.MapperConfiguration().CreateMapper();
            _AD_DEVSOLICITACAO = aD_DEVSOLICITACAO;
            _UserRepository = UserRepository;
            _TSIEMPRepository = TSIEMPRepository;
        }


        [HttpGet]
        [Authorize]
        [Route("GetByNuSoldevDevolucao")]
        public async Task<ActionResult<IResponse<AD_DEVSOLICITACAODTODevolucao>>> GetByIdNF(int nuSoldev)
        {
            var response = new Response<AD_DEVSOLICITACAODTODevolucao>();
            try
            {
                AD_DEVSOLICITACAODTODevolucao result = await this._AD_DEVSOLICITACAO.GetDevolucaoByNuSoldev(nuSoldev);
                short codEmpresa = (short)result.CodEmp;
                if (result != null)
                {
                    result.Empresa = _mapper.Map<TSIEMPDevolucaoDTO>(await this._TSIEMPRepository.GetByCODEMP((int)result.CodEmp));
                    response.SetConfig(200);
                    response.Data = result;
                }
                else
                {
                    response.SetConfig(404, "Devolução não encontrada", false);
                }
            }
            catch (System.Exception e)
            {
                response.SetConfig(400, "Erro ao buscar devolução " + e.Message, false);
            }
            return response.GetResponse();
        }

        [HttpGet]
        [Authorize]
        [Route("GetAllDevolucao")]
        public async Task<ActionResult<IResponse<List<AD_DEVSOLICITACAODTODevolucao>>>> GetAllDevolucao(int codParc, int page = 1, int limit = 10)
        {
            var response = new Response<List<AD_DEVSOLICITACAODTODevolucao>>();

            try
            {

                var result = await _AD_DEVSOLICITACAO.GetAllDevolucaoPaginateAsync(page, limit, codParc);
                foreach (var devoluca in result.Data)
                {
                    devoluca.Empresa = _mapper.Map<TSIEMPDevolucaoDTO>(await this._TSIEMPRepository.GetByCODEMP((int)devoluca.CodEmp));
                }
                response.SetConfig(200);
                response.Data = result.Data;
            }
            catch (System.Exception)
            {
                response.SetConfig(400, "Erro ao buscar Devolução", false);
            }
            return response.GetResponse();
        }

        [HttpGet]
        [Authorize]
        [Route("GetAllDevolucaoSAC")]
        public async Task<ActionResult<IResponse<List<AD_DEVSOLICITACAOSACDTO>>>> GetAllDevolucaoSAC(int page = 1, int limit = 10)
        {
            var response = new Response<List<AD_DEVSOLICITACAOSACDTO>>();
            string token = "";
            var authorization = Request.Headers[HeaderNames.Authorization];
            if (AuthenticationHeaderValue.TryParse(authorization, out var headerValue))
            {
                token = headerValue.Parameter;
            }
            var id = TokenService.getIdByToken(token);
            var user = await _UserRepository.GetById(id);

            try
            {

                var result = await _AD_DEVSOLICITACAO.GetAllDevolucaoSACPaginateAsync(page, limit, (int)user.VendedorUCod);
                foreach (var devoluca in result.Data)
                {
                    devoluca.Empresa = _mapper.Map<TSIEMPDTOSAC>(await this._TSIEMPRepository.GetByCODEMP((int)devoluca.CodEmp));
                }
                response.SetConfig(200);
                response.Data = result.Data;
            }
            catch (System.Exception)
            {
                response.SetConfig(400, "Erro ao buscar SAC", false);
            }
            return response.GetResponse();
        }
    }
}