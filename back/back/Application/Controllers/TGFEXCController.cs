using back.data.http;
using back.domain.DTO.TGFEXC;
using back.domain.entities;
using back.domain.Repositories;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace back.Application.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TGFEXCController : ControllerBase
    {
        protected readonly ITGFEXCRepository _TGFEXCRepository;

        public TGFEXCController(ITGFEXCRepository TGFEXCRepository)
        {
            _TGFEXCRepository = TGFEXCRepository;
        }

        [HttpGet]
        [Authorize]
        public async Task<ActionResult<IResponse<List<TGFEXCDTO>>>> GetAll(int page = 1, int limit = 10)
        {
            var response = new Response<List<TGFEXCDTO>>();
            try
            {
                var result = await _TGFEXCRepository.GetAllPaginateAsync(page, limit);
                response.SetConfig(200);
                response.Data = result.Data;
            }
            catch (System.Exception)
            {
                response.SetConfig(400, "Erro ao buscar as ", false);
            }
            return response.GetResponse();
        }
    }
}
