using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using back.data.http;
using back.domain.DTO.TSICidadeDTO;
using back.domain.entities;
using back.domain.Repositories;
using back.infra.Data.Utils;
using back.MappingConfig;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace back.Application.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TSICIDController : ControllerBase
    {
        private readonly ITSICIDRepository _ITSICIDRepository;
        private readonly IMapper _mapper;

        public TSICIDController(ITSICIDRepository TSICIDRepository, IMapper mapper)
        {
            _ITSICIDRepository = TSICIDRepository;
            _mapper = MapperConfig.MapperConfiguration().CreateMapper();
        }

        [HttpGet("{id}")]
        [Authorize]
        public async Task<ActionResult<IResponse<TSICIDDTO>>> GetById(int id)
        {
            var response = new Response<TSICIDDTO>();
            try
            {
                TSICIDDTO result = await this._ITSICIDRepository.GetById(id);
                if (result != null)
                {
                    response.SetConfig(200);
                    response.Data = result;
                }
                else
                {
                    response.SetConfig(404, "Cidade não encontrado", false);
                }
            }
            catch (System.Exception e)
            {
                response.SetConfig(400, "Erro ao buscar cidade " + e.Message, false);
            }
            return response.GetResponse();
        }

        [HttpGet]
        [Authorize]
        [Route("GetByNomeEnd")]
        public async Task<ActionResult<IResponse<TSICIDDTO>>> GetByNomeEnd(string nomeEnd)
        {
            var response = new Response<TSICIDDTO>();
            try
            {
                TSICIDDTO result = await this._ITSICIDRepository.GetByNome(nomeEnd);
                if (result != null)
                {
                    response.SetConfig(200);
                    response.Data = result;
                }
                else
                {
                    response.SetConfig(404, "Cidade não encontrado", false);
                }
            }
            catch (System.Exception e)
            {
                response.SetConfig(400, "Erro ao buscar cidade " + e.Message, false);
            }
            return response.GetResponse();
        }
        [HttpPost]
        [Authorize]
        [Route("Create")]
        public async Task<ActionResult<IResponse<bool>>> create(TSICIDDTOCreate tsiend)
        {
            tsiend.Dtalter = System.DateTime.Now;
            var response = new Response<bool>();
            try
            {
                var result = await this._ITSICIDRepository.Create(tsiend);
                if (result)
                {
                    response.SetConfig(200);
                    response.Data = result;
                }
                else
                {
                    response.SetConfig(404, "Cidade não criado", false);
                }
            }
            catch (System.Exception e)
            {
                response.SetConfig(400, "Erro ao criar o cidade " + InnerExceptionMessage.InnerExceptionError(e), false);
            }
            return response.GetResponse();
        }
    }
}