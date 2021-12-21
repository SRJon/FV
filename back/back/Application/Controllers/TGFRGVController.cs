using back.data.http;
using back.domain.DTO.TGFRGV;
using back.domain.entities;
using back.domain.Repositories;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;


/*
 * Controle da tabela TGFGRU do Sankhya somente leitura - GRUPO DE PRODUTO VENDEDOR
 */
namespace back.Application.Controllers
{

    [ApiController]
    [Route("api/[controller]")]
    public class TGFRGVController : ControllerBase
    {
        protected readonly ITGFRGVRepository _TGFRGVRepository;

        public TGFRGVController(ITGFRGVRepository TGFRGVRepository)
        {
            _TGFRGVRepository = TGFRGVRepository;
        }


        /*
         * Consulta todos os registros e quantidade de páginas da tabela TGFRGV
         */
        [HttpGet]
        //[Authorize]

        public async Task<ActionResult<IResponse<List<TGFRGVDTO>>>> GetAll(int page = 1, int limit = 10)
        {
            var response = new Response<List<TGFRGVDTO>>();
            try
            {
                var result = await _TGFRGVRepository.GetAllPaginateAsync(page, limit);
                response.SetConfig(200);
                response.Data = result.Data;
            }
            catch (System.Exception)
            {
                response.SetConfig(400, "Erro ao buscar os Vendedores", false);
            }
            return response.GetResponse();
        }

        /*
         * Consulta do registro pelo código do Grupo de Produto "CODGRUPOPROD" da tabela TGFRGV
         */
        [HttpGet("CodGrupoProd/{CODGRUPOPROD}")]
        //[Authorize]
        public async Task<ActionResult<Response<TGFRGVDTO>>> GetByCODGRUPOPROD(int CODGRUPOPROD)
        {

            var response = new Response<TGFRGVDTO>();
            try
            {
                TGFRGVDTO result = await this._TGFRGVRepository.GetByCODGRUPOPROD(CODGRUPOPROD);
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

       /*
        * Consulta do registro pelo código de vendedor "CODVEND" da tabela TGFRGV
        */
        [HttpGet("CodVend/{CODVEND}")]
        //[Authorize]
        public async Task<ActionResult<IResponse<List<TGFRGVDTO>>>> GetByCODVEND(short CODVEND)
        {
            var response = new Response<List<TGFRGVDTO>>();
            try
            {
                var result = await this._TGFRGVRepository.GetByCODVEND(CODVEND);
                response.SetConfig(200);
                response.Data = result.Data;
            }
            catch (System.Exception)
            {
                response.SetConfig(400, "Erro ao buscar os Vendedores", false);
            }
            return response.GetResponse();
        }


    }
}
