using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using back.data.entities.Enterprise;
using back.data.http;
using back.domain.DTO.Empresa;
using back.domain.Repositories;
using back.MappingConfig;
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
            Response<EmpresaDTO> response = null;

            try
            {
                EmpresaDTO result = await this._empresaRepository.GetById(id);
                if (result != null)
                {
                    response = new Response<EmpresaDTO>
                    {
                        Message = "Empresa encontrada com sucesso",
                        Data = result,
                        Success = true,
                        StatusCode = 200
                    };
                }
                else
                {
                    response = new Response<EmpresaDTO>
                    {
                        Message = "Empresa não encontrada",
                        Data = null,
                        Success = false,
                        StatusCode = 404
                    };
                }
            }
            catch (System.Exception e)
            {

                return BadRequest(new Response<string>
                {
                    Message = "Erro ao buscar a empresa",
                    Data = e.Message,
                    Success = false,
                    StatusCode = 400
                });


            }


            return Ok(response);
        }

    }
}