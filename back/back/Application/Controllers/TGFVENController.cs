using back.data.http;
using back.domain.DTO.TGFVEN;
using back.domain.entities;
using back.domain.Repositories;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

/*
 * Controle da tabela TGFVEN do Sankhya somente leitura - VENDEDORES
 */
namespace back.Application.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TGFVENController : ControllerBase
    {
        protected readonly ITGFVENRepository _TGFVENRepository;

        public TGFVENController(ITGFVENRepository TGFVENRepository)
        {
            _TGFVENRepository = TGFVENRepository;
        }



        /*
         * Consulta todos os registros e quantidade de páginas da tabela TGFVEN
         */
        [HttpGet]
        [Authorize]

        public async Task<ActionResult<IResponse<List<TGFVENDTO>>>> GetAll(int page = 1, int limit = 10)
        {
            var response = new Response<List<TGFVENDTO>>();
            try
            {
                var result = await _TGFVENRepository.GetAllPaginateAsync(page, limit);
                response.SetConfig(200);
                response.Data = result.Data;
                response.setHttpAtr(result);
            }
            catch (System.Exception)
            {
                response.SetConfig(400, "Erro ao buscar os Vendedores", false);
            }
            return response.GetResponse();
        }

        /*
         * Consulta do registro pelo código da empresa "CODEMP" da tabela TGFVEN
         */
        [HttpGet("{CODVEND}")]
        [Authorize]
        public async Task<ActionResult<Response<TGFVENDTO>>> GetByCODVEND(int CODVEND)
        {

            var response = new Response<TGFVENDTO>();
            try
            {
                TGFVENDTO result = await this._TGFVENRepository.GetByCODVEND(CODVEND);
                if (result != null)
                {
                    response.SetConfig(200);
                    response.Data = result;
                }
                else
                {
                    response.SetConfig(404, "Vendedor não encontrado", false);
                }
            }
            catch (System.Exception e)
            {
                response.SetConfig(400, "Erro ao buscar o vendedor " + e.Message, false);
            }
            return Ok(response);
        }

    }
}
