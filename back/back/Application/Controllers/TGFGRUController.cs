using back.data.http;
using back.domain.DTO.TGFGrupoProduto;
using back.domain.entities;
using back.domain.Repositories;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

/*
 * Controle da tabela TGFGRU do Sankhya somente leitura - GRUPO DE PRODUTO
 */
namespace back.Application.Controllers
{

    [ApiController]
    [Route("api/[controller]")]
    public class TGFGRUController : ControllerBase
    {
        protected readonly ITGFGRURepository _TGFGRURepository;

        public TGFGRUController(ITGFGRURepository TGFGRURepository)
        {
            _TGFGRURepository = TGFGRURepository;
        }



       /*
        * Consulta todos os registros e quantidade de páginas da tabela TGFGRU
        */
        [HttpGet]
        [Authorize]

        public async Task<ActionResult<IResponse<List<TGFGRUDTO>>>> GetAll(int page = 1, int limit = 10)
        {
            var response = new Response<List<TGFGRUDTO>>();
            try
            {
                var result = await _TGFGRURepository.GetAllPaginateAsync(page, limit);
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
         * Consulta do registro pelo código do Grupo de Produto "CODGRUPOPROD" da tabela TGFGRU
         */
        [HttpGet("CodGrupoProd/{CODGRUPOPROD}")]
        [Authorize]
        public async Task<ActionResult<Response<TGFGRUDTO>>> GetByCODGRUPOPROD(int CODGRUPOPROD)
        {

            var response = new Response<TGFGRUDTO>();
            try
            {
                TGFGRUDTO result = await this._TGFGRURepository.GetByCODGRUPOPROD(CODGRUPOPROD);
                if (result != null)
                {
                    response.SetConfig(200);
                    response.Data = result;
                }
                else
                {
                    response.SetConfig(404, "Grupo de Produto não encontrado", false);
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

