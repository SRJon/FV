using back.data.http;
using back.domain.DTO.AD_FAMGR2;
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
    public class AD_FAMGR2Controller : ControllerBase
    {

        protected readonly IAD_FAMGR2Repository _AD_FAMGR2Repository;

        public AD_FAMGR2Controller(IAD_FAMGR2Repository AD_FAMGR2Repository)
        {
            _AD_FAMGR2Repository = AD_FAMGR2Repository;
        }


        [HttpGet]
        [Authorize]
        public async Task<ActionResult<IResponse<List<AD_FAMGR2DTO>>>> GetAll(int page = 1, int limit = 10)
        {
            var response = new Response<List<AD_FAMGR2DTO>>();
            try
            {
                var result = await _AD_FAMGR2Repository.GetAllPaginateAsync(page, limit);
                response.SetConfig(200);
                response.Data = result.Data;
                response.setHttpAtr(result);
            }
            catch (System.Exception)
            {
                response.SetConfig(400, "Erro ao buscar as Família de Produtos Grau 2", false);
            }
            return response.GetResponse();
        }
    }
}
