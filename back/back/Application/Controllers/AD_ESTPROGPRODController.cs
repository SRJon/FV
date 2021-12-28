using back.data.http;
using back.domain.DTO.AD_ESTPROGPROD;
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
    public class AD_ESTPROGPRODController : ControllerBase
    {

        protected readonly IAD_ESTPROGPRODRepository _AD_ESTPROGPRODRepository;

        public AD_ESTPROGPRODController(IAD_ESTPROGPRODRepository AD_ESTPROGPRODRepository)
        {
            _AD_ESTPROGPRODRepository = AD_ESTPROGPRODRepository;
        }


        [HttpGet]
        [Authorize]
        public async Task<ActionResult<IResponse<List<AD_ESTPROGPRODDTO>>>> GetAll(int page = 1, int limit = 10)
        {
            var response = new Response<List<AD_ESTPROGPRODDTO>>();
            try
            {
                var result = await _AD_ESTPROGPRODRepository.GetAllPaginateAsync(page, limit);
                response.SetConfig(200);
                response.Data = result.Data;
                response.setHttpAtr(result);
            }
            catch (System.Exception)
            {
                response.SetConfig(400, "Erro ao buscar os Estoques Programados", false);
            }
            return response.GetResponse();
        }



    }
}
