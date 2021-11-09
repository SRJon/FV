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
            Response<List<EmpresaDTO>> result = null;
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

        [HttpPost]
        [Authorize]
        [Route("Create")]
        public async Task<ActionResult<Response<bool>>> create(Empresa empresa)
        {
            Response<bool> response = null;

            try
            {
                var result = await this._empresaRepository.Create(empresa);
                if (result)
                {
                    response = new Response<bool>
                    {
                        Message = "Empresa criada com sucesso",
                        Data = result,
                        Success = true,
                        StatusCode = 200
                    };
                }
                else
                {
                    response = new Response<bool>
                    {
                        Message = "Empresa não criada",
                        Data = result,
                        Success = false,
                        StatusCode = 404
                    };
                }
            }
            catch (System.Exception e)
            {

                return BadRequest(new Response<string>
                {
                    Message = "Erro ao criar a Empresa",
                    Data = e.Message,
                    Success = false,
                    StatusCode = 400
                });
            }


            return Ok(response);

        }

        [HttpPost()]
        [Route("Update")]
        [Authorize]
        public async Task<ActionResult<Response<bool>>> update(Empresa empresa)
        {
            Response<bool> response = null;
            try
            {
                var result = await this._empresaRepository.Update(empresa);
                if (result)
                {
                    response = new Response<bool>
                    {
                        Message = "Empresa atualizada com sucesso",
                        Data = result,
                        Success = true,
                        StatusCode = 200
                    };
                }
                else
                {
                    response = new Response<bool>
                    {
                        Message = "Empresa não atualizada",
                        Data = result,
                        Success = false,
                        StatusCode = 404
                    };
                }
                return response;
            }
            catch (System.Exception e)
            {
                return BadRequest(new Response<string>
                {
                    Message = "Erro ao atualizar a empresa",
                    Data = e.Message,
                    Success = false,
                    StatusCode = 400
                });
            }
        }
        [HttpPost]
        [Route("Delete")]
        [Authorize]
        public async Task<ActionResult<Response<bool>>> delete(int id)
        {
            Response<bool> response = null;
            try
            {
                var result = await this._empresaRepository.Delete(id);
                if (result)
                {
                    response = new Response<bool>
                    {
                        Message = "Empresa excluida com sucesso",
                        Data = result,
                        Success = true,
                        StatusCode = 200
                    };
                }
                else
                {
                    response = new Response<bool>
                    {
                        Message = "Empresa não excluida",
                        Data = result,
                        Success = false,
                        StatusCode = 404
                    };
                }
                return response;
            }
            catch (System.Exception e)
            {
                return BadRequest(new Response<string>
                {
                    Message = "Erro ao excluir a empresa",
                    Data = e.Message,
                    Success = false,
                    StatusCode = 400
                });
            }
        }


    }

}
