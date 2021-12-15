using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using AutoMapper;
using back.data.entities.TGFTPVenda;
using back.data.http;
using back.domain.DTO.TGFCABNotaDTO;
using back.domain.DTO.TGFTPVendaDTO;
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
    public class TGFCABController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly ITGFCABRepository _TGFCABRespotory;
        private readonly ITGFTPVRepository _TGFTPVRepository;
        private readonly IUserRepository _UserRepository;

        public TGFCABController(ITGFCABRepository tGFCABRespotory, ITGFTPVRepository tGFTPVRepository, IUserRepository UserRepository)
        {
            _mapper = MapperConfig.MapperConfiguration().CreateMapper();
            _TGFCABRespotory = tGFCABRespotory;
            _TGFTPVRepository = tGFTPVRepository;
            _UserRepository = UserRepository;
        }


        [HttpGet("NuNota")]
        [Authorize]
        public async Task<ActionResult<IResponse<TGFCABDTO>>> GetById(int nunota)
        {
            var response = new Response<TGFCABDTO>();
            try
            {
                TGFCABDTO result = await this._TGFCABRespotory.GetById(nunota);
                if (result != null)
                {
                    response.SetConfig(200);
                    response.Data = result;
                }
                else
                {
                    response.SetConfig(404, "Nota não encontrada", false);
                }
            }
            catch (System.Exception e)
            {
                response.SetConfig(400, "Erro ao buscar nota " + e.Message, false);
            }
            return response.GetResponse();
        }

        [HttpGet]
        [Authorize]
        [Route("GetByIdACABNF")]
        public async Task<ActionResult<IResponse<TGFCABNuNotaDTO>>> GetByIdNF(int numnota)
        {
            var response = new Response<TGFCABNuNotaDTO>();
            try
            {
                TGFCABNuNotaDTO result = await this._TGFCABRespotory.GetByIdNF(numnota);
                if (result != null)
                {
                    response.SetConfig(200);
                    response.Data = result;
                }
                else
                {
                    response.SetConfig(404, "Nota não encontrada", false);
                }
            }
            catch (System.Exception e)
            {
                response.SetConfig(400, "Erro ao buscar nota " + e.Message, false);
            }
            return response.GetResponse();
        }


        [HttpGet]
        [Authorize]
        [Route("GetAllACAB")]
        public async Task<ActionResult<IResponse<List<TGFCABDTO>>>> GetAll(int codParc, int page = 1, int limit = 10)
        {
            var response = new Response<List<TGFCABDTO>>();
            try
            {
                var result = await _TGFCABRespotory.GetAllPaginateAsync(codParc, page, limit);
                response.SetConfig(200);
                response.Data = result.Data;
            }
            catch (System.Exception)
            {
                response.SetConfig(400, "Erro ao buscar TGFCAB", false);
            }
            return response.GetResponse();
        }
        [HttpGet]
        [Authorize]
        [Route("GetAllACABNF")]
        public async Task<ActionResult<IResponse<List<TGFCABNuNotaDTO>>>> GetAllNF(int codParc, int page = 1, int limit = 10)
        {
            var response = new Response<List<TGFCABNuNotaDTO>>();

            try
            {

                var result = await _TGFCABRespotory.GetAllNFPaginateAsync(page, limit, codParc);
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