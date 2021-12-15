using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using back.data.http;
using back.domain.DTO.TSIBairroDTO;
using back.domain.entities;
using back.domain.Repositories;
using back.infra.Data.Utils;
using back.MappingConfig;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace back.Application.Controllers
{
    [Route("api/[controller]")]
    public class TSIBAIController : ControllerBase
    {
        private readonly ITSIBAIRepository _ITSIBAIRepository;
        private readonly IMapper _mapper;
        public TSIBAIController(ITSIBAIRepository TSIBAIRepository, IMapper mapper)
        {
            _ITSIBAIRepository = TSIBAIRepository;
            _mapper = MapperConfig.MapperConfiguration().CreateMapper();
        }

        [HttpGet("{id}")]
        [Authorize]
        public async Task<ActionResult<IResponse<TSIBAIDTO>>> GetById(int id)
        {
            var response = new Response<TSIBAIDTO>();
            try
            {
                TSIBAIDTO result = await this._ITSIBAIRepository.GetById(id);
                if (result != null)
                {
                    response.SetConfig(200);
                    response.Data = result;
                }
                else
                {
                    response.SetConfig(404, "Bairro não encontrado", false);
                }
            }
            catch (System.Exception e)
            {
                response.SetConfig(400, "Erro ao buscar bairro " + e.Message, false);
            }
            return response.GetResponse();
        }

        [HttpGet]
        [Authorize]
        [Route("GetByNomeEnd")]
        public async Task<ActionResult<IResponse<TSIBAIDTO>>> GetByNomeEnd(string nomeEnd)
        {
            var response = new Response<TSIBAIDTO>();
            try
            {
                TSIBAIDTO result = await this._ITSIBAIRepository.GetByNome(nomeEnd);
                if (result != null)
                {
                    response.SetConfig(200);
                    response.Data = result;
                }
                else
                {
                    response.SetConfig(404, "Bairro não encontrado", false);
                }
            }
            catch (System.Exception e)
            {
                response.SetConfig(400, "Erro ao buscar bairro " + e.Message, false);
            }
            return response.GetResponse();
        }

        [HttpPost]
        [Authorize]
        [Route("Create")]
        public async Task<ActionResult<IResponse<bool>>> create(TSIBAIDTOCreate tsiend)
        {
            tsiend.Dtalter = System.DateTime.Now;
            var response = new Response<bool>();
            try
            {
                var result = await this._ITSIBAIRepository.Create(tsiend);
                if (result)
                {
                    response.SetConfig(200);
                    response.Data = result;
                }
                else
                {
                    response.SetConfig(404, "Bairro não criado", false);
                }
            }
            catch (System.Exception e)
            {
                response.SetConfig(400, "Erro ao criar o bairro " + InnerExceptionMessage.InnerExceptionError(e), false);
            }
            return response.GetResponse();
        }


    }
}