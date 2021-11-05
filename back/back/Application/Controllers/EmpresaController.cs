using System.Collections.Generic;
using System.Threading.Tasks;
using back.data.entities.Enterprise;
using back.data.http;
using back.domain.Repositories;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace back.Application.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EmpresaController : ControllerBase
    {
        private IEmpresaRepository _empresaRepository;

        public EmpresaController(IEmpresaRepository empresaRepository)
        {
            _empresaRepository = empresaRepository;
        }

        [HttpGet]
        [Authorize]
        public async Task<ActionResult<Response<List<Empresa>>>> GetAllAsync([FromQuery] EmpresaGetAllEntity payload)

        {
            Response<List<Empresa>> result = null;
            try
            {
                result = await _empresaRepository.GetAllPaginateAsync(payload.page, payload.limit);
            }
            catch (System.Exception e)
            {
                return BadRequest(new Response<string>
                {
                    Message = "Erro ao buscar as Empresas",
                    Data = e.Message,
                    Success = false,
                    StatusCode = 400

                });

            }
            return Ok(result);
        }

        [HttpGet("{id}")]
        [Authorize]
        public async Task<ActionResult<Response<Empresa>>> getById(int id)
        {
            Response<Empresa> response = null;

            try
            {
                Empresa result = await this._empresaRepository.GetById(id);


            }
            catch (System.Exception e)
            {

            }


            return Ok(response);
        }

    }
}