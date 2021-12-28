using back.data.http;
using back.domain.DTO.TGFIPI;
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
    public class TGFIPIController : ControllerBase
    {
        protected readonly ITGFIPIRepository _TGFIPIRepository;

        public TGFIPIController(ITGFIPIRepository TGFIPIRepository)
        {
            _TGFIPIRepository = TGFIPIRepository;
        }

        [HttpGet]
        [Authorize]
        public async Task<ActionResult<IResponse<List<TGFIPIDTO>>>> GetAll(int page = 1, int limit = 10)
        {
            var response = new Response<List<TGFIPIDTO>>();
            try
            {
                var result = await _TGFIPIRepository.GetAllPaginateAsync(page, limit);
                response.SetConfig(200);
                response.Data = result.Data;
                response.setHttpAtr(result);
            }
            catch (System.Exception)
            {
                response.SetConfig(400, "Erro ao buscar as Alíquotas de IPI", false);
            }
            return response.GetResponse();
        }
    }
}
