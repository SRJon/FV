using back.data.http;
using back.domain.DTO.AD_Estoque;
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
    public class AD_ESTCODPRODController : ControllerBase
    {
        protected readonly IAD_ESTCODPRODRepository _AD_ESTCODPRODRepository;

        public AD_ESTCODPRODController(IAD_ESTCODPRODRepository AD_ESTPROGPRODRepository)
        {
            _AD_ESTCODPRODRepository = AD_ESTPROGPRODRepository;
        }

        [HttpGet]
        [Authorize]
        public async Task<ActionResult<IResponse<List<AD_ESTCODPRODDTO>>>> GetAll(int page = 1, int limit = 10, int Produto = -1, int CodGrupoProd = -1, string DescrProd = null, string ComplDesc = null)
        {
            var response = new Response<List<AD_ESTCODPRODDTO>>();
            try
            {
                var result = await _AD_ESTCODPRODRepository.GetSearchPaginateAsync(page, limit, Produto, CodGrupoProd, DescrProd, ComplDesc);
                response.SetConfig(200);
                response.Data = result.Data;
                response.setHttpAtr(result);
            }
            catch (System.Exception)
            {
                response.SetConfig(400, "Erro ao buscar o estoque dos produtos", false);
            }
            return response.GetResponse();
        }
    }
}
