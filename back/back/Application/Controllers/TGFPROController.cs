using back.data.http;
using back.domain.DTO.TGFProdutoDTO;
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
    public class TGFPROController : ControllerBase
    {
        protected readonly ITGFPRORepository _TGFPRORepository;

        public TGFPROController(ITGFPRORepository TGFPRORepository)
        {
            _TGFPRORepository = TGFPRORepository;
        }

        [HttpGet]
        [Authorize]
        public async Task<ActionResult<IResponse<List<TGFPRODTO>>>> GetAll(int page = 1, int limit = 10)
        {
            var response = new Response<List<TGFPRODTO>>();
            try
            {
                var result = await _TGFPRORepository.GetAllPaginateAsync(page, limit);
                response.SetConfig(200);
                response.Data = result.Data;
            }
            catch (System.Exception)
            {
                response.SetConfig(400, "Erro ao buscar os Produtos", false);
            }
            return response.GetResponse();
        }
    }
}
