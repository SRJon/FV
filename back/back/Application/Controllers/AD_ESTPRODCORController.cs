using back.data.http;
using back.domain.DTO.AD_ESTPRODCOR;
using back.domain.entities;
using back.domain.Repositories;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace back.Application.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AD_ESTPRODCORController : ControllerBase
    {
        protected readonly IAD_ESTPRODCORRepository _AD_ESTPRODCORRepository;

        public AD_ESTPRODCORController(IAD_ESTPRODCORRepository AD_ESTPRODCORRepository)
        {
            _AD_ESTPRODCORRepository = AD_ESTPRODCORRepository;
        }

        [HttpGet]
        [Authorize]
        public async Task<ActionResult<IResponse<List<AD_ESTPRODCORDTO>>>> GetAll(int page = 1, int limit = 10)
        {
            var response = new Response<List<AD_ESTPRODCORDTO>>();
            try
            {
                var result = await _AD_ESTPRODCORRepository.GetAllPaginateAsync(page, limit);
                response.SetConfig(200);
                response.Data = result.Data;
            }
            catch (System.Exception)
            {
                response.SetConfig(400, "Erro ao buscar os estoque dos produtos pela Cor", false);
            }
            return response.GetResponse();
        }
    }
}
