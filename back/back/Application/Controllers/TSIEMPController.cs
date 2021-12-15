using back.data.http;
using back.domain.DTO.TSIEmpDTO;
using back.domain.entities;
using back.domain.Repositories;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

/*
 * Controle da tabela TSIEMP do Sankhya somente leitura - EMPRESAS
 */
namespace back.Application.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TSIEMPController : ControllerBase
    {
        protected readonly ITSIEMPRepository _TSIEMPRepository;

        public TSIEMPController(ITSIEMPRepository TSIEMPRepository)
        {
            _TSIEMPRepository = TSIEMPRepository;
        }



        /*
         * Consulta todos os registros e quantidade de páginas da tabela TSIEMP
         */
        [HttpGet]
        [Authorize]

        public async Task<ActionResult<IResponse<List<TSIEMPDTO>>>> GetAll(int page = 1, int limit = 10)
        {
            var response = new Response<List<TSIEMPDTO>>();
            try
            {
                var result = await _TSIEMPRepository.GetAllPaginateAsync(page, limit);
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
         * Consulta do registro pelo código de vendedor "CODEMP" da tabela TSIEMP
         */
        [HttpGet("{CODEMP}")]
        [Authorize]
        public async Task<ActionResult<Response<TSIEMPDTO>>> GetByCODEMP(int CODEMP)
        {

            var response = new Response<TSIEMPDTO>();
            try
            {
                TSIEMPDTO result = await this._TSIEMPRepository.GetByCODEMP(CODEMP);
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
