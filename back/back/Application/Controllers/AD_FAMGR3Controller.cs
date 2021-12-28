using back.data.http;
using back.domain.DTO.AD_FAMGR3;
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
    public class AD_FAMGR3Controller : ControllerBase
    {
        protected readonly IAD_FAMGR3Repository _AD_FAMGR3Repository;

        public AD_FAMGR3Controller(IAD_FAMGR3Repository AD_FAMGR3Repository)
        {
            _AD_FAMGR3Repository = AD_FAMGR3Repository;
        }


        [HttpGet]
        [Authorize]
        public async Task<ActionResult<IResponse<List<AD_FAMGR3DTO>>>> GetAll(int page = 1, int limit = 10)
        {
            var response = new Response<List<AD_FAMGR3DTO>>();
            try
            {
                var result = await _AD_FAMGR3Repository.GetAllPaginateAsync(page, limit);
                response.SetConfig(200);
                response.Data = result.Data;
                response.setHttpAtr(result);
            }
            catch (System.Exception)
            {
                response.SetConfig(400, "Erro ao buscar as Família de Produtos Grau 3", false);
            }
            return response.GetResponse();
        }
    }
}
