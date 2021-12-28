using back.data.http;
using back.domain.DTO.VGFTAB;
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
    public class VGFTABController : ControllerBase
    {
        protected readonly IVGFTABRepository _VGFTABRepository;

        public VGFTABController(IVGFTABRepository VGFTABRepository)
        {
            _VGFTABRepository = VGFTABRepository;
        }

        [HttpGet]
        [Authorize]
        public async Task<ActionResult<IResponse<List<VGFTABDTO>>>> GetAll(int page = 1, int limit = 10)
        {
            var response = new Response<List<VGFTABDTO>>();
            try
            {
                var result = await _VGFTABRepository.GetAllPaginateAsync(page, limit);
                response.SetConfig(200);
                response.Data = result.Data;
                response.setHttpAtr(result);
            }
            catch (System.Exception)
            {
                response.SetConfig(400, "Erro ao buscar as Tabela de Preços", false);
            }
            return response.GetResponse();
        }
    }
}
