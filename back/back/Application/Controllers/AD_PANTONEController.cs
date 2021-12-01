using back.data.http;
using back.domain.DTO.AD_PANTONE;
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
    public class AD_PANTONEController : ControllerBase
    {
        protected readonly IAD_PANTONERepository _AD_PANTONERepository;

        public AD_PANTONEController(IAD_PANTONERepository AD_PANTONERepository)
        {
            _AD_PANTONERepository = AD_PANTONERepository;
        }

        [HttpGet]
        [Authorize]
        public async Task<ActionResult<IResponse<List<AD_PANTONEDTO>>>> GetAll(int page = 1, int limit = 10)
        {
            var response = new Response<List<AD_PANTONEDTO>>();
            try
            {
                var result = await _AD_PANTONERepository.GetAllPaginateAsync(page, limit);
                response.SetConfig(200);
                response.Data = result.Data;
            }
            catch (System.Exception)
            {
                response.SetConfig(400, "Erro ao buscar os Pantones", false);
            }
            return response.GetResponse();
        }

        [HttpGet("{CodCor}")]
        [Authorize]
        public async Task<ActionResult<Response<AD_PANTONEDTO>>> GetByCODEMP(int CodCor)
        {

            var response = new Response<AD_PANTONEDTO>();
            try
            {
                AD_PANTONEDTO result = await this._AD_PANTONERepository.GetByCodCor(CodCor);
                if (result != null)
                {
                    response.SetConfig(200);
                    response.Data = result;
                }
                else
                {
                    response.SetConfig(404, "Pantone não encontrado", false);
                }
            }
            catch (System.Exception e)
            {
                response.SetConfig(400, "Erro ao buscar o Pantone " + e.Message, false);
            }
            return Ok(response);
        }
    }
}
