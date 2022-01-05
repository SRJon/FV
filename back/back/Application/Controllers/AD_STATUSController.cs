using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using back.data.http;
using back.domain.DTO.AD_STATUS;
using back.domain.entities;
using back.domain.Repositories;
using back.MappingConfig;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace back.Application.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AD_STATUSController : ControllerBase
    {
        private readonly IAD_STATUSRepository _STATUSRepository;
        private readonly IMapper _mapper;

        public AD_STATUSController(IAD_STATUSRepository sTATUSRepository)
        {
            _STATUSRepository = sTATUSRepository;
            _mapper = MapperConfig.MapperConfiguration().CreateMapper();
        }


        [HttpGet]
        [Authorize]
        [Route("GetAllPedidos")]
        public async Task<ActionResult<IResponse<List<AD_STATUSDTO>>>> GetAllDevolucao(int page = 1, int limit = 10)
        {

            var response = new Response<List<AD_STATUSDTO>>();
            try
            {
                var result = await _STATUSRepository.GetAllPaginateAsync(page, limit);
                response.SetConfig(200);
                response.Data = result.Data;
            }
            catch (System.Exception)
            {
                response.SetConfig(400, "Erro ao buscar Status", false);
            }
            return response.GetResponse();
        }

        [HttpGet]
        [Authorize]
        [Route("GetByNuNota")]
        public async Task<ActionResult<IResponse<AD_STATUSDTO>>> GetById(int NuNota)
        {
            var response = new Response<AD_STATUSDTO>();
            try
            {
                AD_STATUSDTO result = await this._STATUSRepository.GetByNuNota(NuNota);
                if (result != null)
                {
                    response.SetConfig(200);
                    response.Data = result;
                }
                else
                {
                    response.SetConfig(404, "Status não encontrado", false);
                }
            }
            catch (System.Exception e)
            {
                response.SetConfig(400, "Erro ao buscar status " + e.Message, false);
            }
            return response.GetResponse();
        }
    }
}