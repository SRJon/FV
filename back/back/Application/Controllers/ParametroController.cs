using System.Collections.Generic;
using System.Threading.Tasks;
using back.data.entities.Parametro;
using back.data.entities.Enterprise;
using back.data.http;
using back.domain.DTO.Parametro;
using back.domain.Repositories;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace back.Application.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ParametroController : ControllerBase
    {
        private IParametroRepository _ParametroRepository;


        public ParametroController(IParametroRepository ParametroRepository)
        {

            _ParametroRepository = ParametroRepository;
        }

        [HttpGet]
        [Authorize]
        public async Task<ActionResult<Response<List<Parametro>>>> GetAllAsync([FromQuery] ParametroGetAllEntity payload)

        {
            Response<List<ParametroDTO>> result = null;
            try
            {
                result = await _ParametroRepository.GetAllPaginateAsync(payload.page, payload.limit);
            }
            catch (System.Exception e)
            {
                return BadRequest(new Response<string>
                {
                    Message = "Erro ao buscar os Parametros",
                    Data = e.Message,
                    Success = false,
                    StatusCode = 400

                });

            }
            return Ok(result);
        }

        [HttpGet("{id}")]
        [Authorize]
        public async Task<ActionResult<Response<Parametro>>> getById(int id)
        {
            Response<ParametroDTO> response = null;

            try
            {
                ParametroDTO result = await this._ParametroRepository.GetById(id);
                if (result != null)
                {
                    response = new Response<ParametroDTO>
                    {
                        Message = "Parametro encontrado com sucesso",
                        Data = result,
                        Success = true,
                        StatusCode = 200
                    };
                }
                else
                {
                    response = new Response<ParametroDTO>
                    {
                        Message = "Parametro não encontrado",
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
                    Message = "Erro ao buscar o Parametro",
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
        public async Task<ActionResult<Response<bool>>> create(Parametro Parametro)
        {
            Response<bool> response = null;

            try
            {
                var result = await this._ParametroRepository.Create(Parametro);
                if (result)
                {
                    response = new Response<bool>
                    {
                        Message = "Parametro criada com sucesso",
                        Data = result,
                        Success = true,
                        StatusCode = 200
                    };
                }
                else
                {
                    response = new Response<bool>
                    {
                        Message = "Parametro não criado",
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
                    Message = "Erro ao criar o Parametro",
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
        public async Task<ActionResult<Response<bool>>> update(Parametro Parametro)
        {
            Response<bool> response = null;
            try
            {
                var result = await this._ParametroRepository.Update(Parametro);
                if (result)
                {
                    response = new Response<bool>
                    {
                        Message = "Parametro atualizado com sucesso",
                        Data = result,
                        Success = true,
                        StatusCode = 200
                    };
                }
                else
                {
                    response = new Response<bool>
                    {
                        Message = "Parametro não atualizado",
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
                    Message = "Erro ao atualizar o Parametro",
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
                var result = await this._ParametroRepository.Delete(id);
                if (result)
                {
                    response = new Response<bool>
                    {
                        Message = "Parametro excluido com sucesso",
                        Data = result,
                        Success = true,
                        StatusCode = 200
                    };
                }
                else
                {
                    response = new Response<bool>
                    {
                        Message = "Parametro não excluido",
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
                    Message = "Erro ao excluir o Parametro",
                    Data = e.Message,
                    Success = false,
                    StatusCode = 400
                });
            }
        }


    }

}
