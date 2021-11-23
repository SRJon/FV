using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using back.data.entities.VIEW_AD_VGFRPV;
using back.data.http;
using back.domain.DTO.AD_VGFRPVDTO;
using back.domain.entities;
using back.domain.Repositories;
using back.MappingConfig;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace back.Application.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AD_VGFRPVController : ControllerBase
    {

        private readonly IMapper _mapper;
        private IAD_VGFRPVRepository _AD_VGFRPVRepository;

        public AD_VGFRPVController(IAD_VGFRPVRepository AD_VGFRPVRepository)
        {
            _mapper = MapperConfig.MapperConfiguration().CreateMapper();
            _AD_VGFRPVRepository = AD_VGFRPVRepository;
        }

        [HttpGet]
        [Authorize]
        public async Task<ActionResult<IResponse<List<AD_VGFRPVDTO>>>> GetAllAsync([FromQuery] AD_VGFRPVGetAllEntity payload)
        {
            var response = new Response<List<AD_VGFRPVDTO>>();
            try
            {
                var result = await _AD_VGFRPVRepository.GetAllPaginateAsync(payload.page, payload.limit);
                response.SetConfig(200);
                response.Data = result.Data;
                response.setHttpAtr(result);
            }
            catch (System.Exception)
            {
                response.SetConfig(404, "Erro ao buscar as AD_VGFRPVs", false);
            }
            return response.GetResponse();
        }

        [HttpGet("{codVend}")]
        [Authorize]
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
    }
}