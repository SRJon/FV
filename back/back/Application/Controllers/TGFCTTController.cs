using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using back.data.http;
using back.domain.DTO.TGFContatoDTO;
using back.domain.entities;
using back.domain.Repositories;
using back.MappingConfig;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace back.Application.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TGFCTTController : ControllerBase
    {
        private readonly IMapper _mapper;
        protected readonly ITGFCTTRepository _TGFCTTRepository;

        public TGFCTTController(IMapper mapper, ITGFCTTRepository tGFCTTRepository)
        {
            this._mapper = MapperConfig.MapperConfiguration().CreateMapper();
            _TGFCTTRepository = tGFCTTRepository;
        }

        [HttpGet]
        [Authorize]
        public async Task<ActionResult<IResponse<TGFCTTDTO>>> GetById(int codParc, int codContato)
        {
            var response = new Response<TGFCTTDTO>();
            try
            {
                TGFCTTDTO result = await this._TGFCTTRepository.GetById(codParc, codContato);
                if (result != null)
                {
                    response.SetConfig(200);
                    response.Data = result;
                }
                else
                {
                    response.SetConfig(404, "Contato não encontrado", false);
                }
            }
            catch (System.Exception e)
            {
                response.SetConfig(400, "Erro ao buscar contato " + e.Message, false);
            }
            return response.GetResponse();
        }
        [HttpGet]
        [Authorize]
        [Route("GetLastCreated")]
        public ActionResult<IResponse<int>> GetLastIdCreated(int codParc)
        {
            var response = new Response<int>();
            int result = _TGFCTTRepository.GetLastIdCreated(codParc);
            response.SetConfig(200);
            response.Data = result;
            return response.GetResponse();
        }
    }
}