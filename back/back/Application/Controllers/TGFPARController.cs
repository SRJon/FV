using System.Collections.Generic;
using System.Threading.Tasks;
using back.data.http;
using back.domain.DTO.TGFParceiroDTO;
using back.domain.entities;
using back.domain.Repositories;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace back.Application.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TGFPARController : ControllerBase
    {
        protected readonly ITGFPARRepository _TGFPARRepository;

        public TGFPARController(ITGFPARRepository TGFPARRepository)
        {
            _TGFPARRepository = TGFPARRepository;
        }

        [HttpGet]
        [Authorize]
        [Route("/")]
        public async Task<ActionResult<IResponse<List<TGFPARDTO>>>> GetAll(int page = 1, int limit = 10)
        {
            var response = new Response<List<TGFPARDTO>>();
            try
            {
                var result = await _TGFPARRepository.GetAllPaginateAsync(page, limit);
                response.SetConfig(200);
                // response.Data = result.Data;
                // response.setHttpAtr(result);
            }
            catch (System.Exception)
            {
                response.SetConfig(400, "Erro ao buscar os parceiros", false);
            }
            return response.GetResponse();
        }

        [HttpGet]
        [Authorize]
        [Route("/{id}")]
        public async Task<ActionResult<Response<TGFPARDTO>>> GetById(int id)
        {

            var response = new Response<TGFPARDTO>();
            try
            {
                TGFPARDTO result = await this._TGFPARRepository.GetById(id);
                if (result != null)
                {
                    response.SetConfig(200);
                    response.Data = result;
                }
                else
                {
                    response.SetConfig(404, "Parceiro não encontrado", false);
                }
            }
            catch (System.Exception e)
            {
                response.SetConfig(400, "Erro ao buscar parceiro" + e.Message, false);
            }
            return Ok(response);
        }

    }
}