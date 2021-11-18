using System.Collections.Generic;
using System.Threading.Tasks;
using back.data.entities.AnexoRep;
using back.data.entities.Enterprise;
using back.data.http;
using back.domain.DTO.AnexoRep;
using back.domain.Repositories;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace back.Application.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AnexoRepController : ControllerBase
    {
        private IAnexoRepRepository _AnexoRepRepository;


        public AnexoRepController(IAnexoRepRepository AnexoRepRepository)
        {

            _AnexoRepRepository = AnexoRepRepository;
        }

        [HttpGet]
        [Authorize]
        public async Task<ActionResult<Response<List<AnexoRep>>>> GetAllAsync([FromQuery] AnexoRepGetAllEntity payload)

        {
            Response<List<AnexoRepDTO>> result = null;
            try
            {
                result = await _AnexoRepRepository.GetAllPaginateAsync(payload.page, payload.limit);
            }
            catch (System.Exception e)
            {
                return BadRequest(new Response<string>
                {
                    Message = "Erro ao buscar os AnexoReps",
                    Data = e.Message,
                    Success = false,
                    StatusCode = 400

                });

            }
            return Ok(result);
        }

        [HttpGet("{id}")]
        [Authorize]
        public async Task<ActionResult<Response<AnexoRep>>> getById(int id)
        {
            Response<AnexoRepDTO> response = null;

            try
            {
                AnexoRepDTO result = await this._AnexoRepRepository.GetById(id);
                if (result != null)
                {
                    response = new Response<AnexoRepDTO>
                    {
                        Message = "AnexoRep encontrado com sucesso",
                        Data = result,
                        Success = true,
                        StatusCode = 200
                    };
                }
                else
                {
                    response = new Response<AnexoRepDTO>
                    {
                        Message = "AnexoRep não encontrado",
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
                    Message = "Erro ao buscar o AnexoRep",
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
        public async Task<ActionResult<Response<bool>>> create(AnexoRep AnexoRep)
        {
            Response<bool> response = null;

            try
            {
                var result = await this._AnexoRepRepository.Create(AnexoRep);
                if (result)
                {
                    response = new Response<bool>
                    {
                        Message = "AnexoRep criada com sucesso",
                        Data = result,
                        Success = true,
                        StatusCode = 200
                    };
                }
                else
                {
                    response = new Response<bool>
                    {
                        Message = "AnexoRep não criado",
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
                    Message = "Erro ao criar o AnexoRep",
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
        public async Task<ActionResult<Response<bool>>> update(AnexoRep AnexoRep)
        {
            Response<bool> response = null;
            try
            {
                var result = await this._AnexoRepRepository.Update(AnexoRep);
                if (result)
                {
                    response = new Response<bool>
                    {
                        Message = "AnexoRep atualizado com sucesso",
                        Data = result,
                        Success = true,
                        StatusCode = 200
                    };
                }
                else
                {
                    response = new Response<bool>
                    {
                        Message = "AnexoRep não atualizado",
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
                    Message = "Erro ao atualizar o AnexoRep",
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
                var result = await this._AnexoRepRepository.Delete(id);
                if (result)
                {
                    response = new Response<bool>
                    {
                        Message = "AnexoRep excluido com sucesso",
                        Data = result,
                        Success = true,
                        StatusCode = 200
                    };
                }
                else
                {
                    response = new Response<bool>
                    {
                        Message = "AnexoRep não excluido",
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
                    Message = "Erro ao excluir o AnexoRep",
                    Data = e.Message,
                    Success = false,
                    StatusCode = 400
                });
            }
        }


    }

}
