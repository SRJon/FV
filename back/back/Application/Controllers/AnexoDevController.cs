using System.Collections.Generic;
using System.Threading.Tasks;
using back.data.entities.AnexoDev;
using back.data.http;
using back.domain.DTO.AnexoDev;
using back.domain.Repositories;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace back.Application.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AnexoDevController : ControllerBase
    {
        private IAnexoDevRepository _AnexoDevRepository;


        public AnexoDevController(IAnexoDevRepository AnexoDevRepository)
        {

            _AnexoDevRepository = AnexoDevRepository;
        }

        [HttpGet]
        [Authorize]
        public async Task<ActionResult<Response<List<AnexoDev>>>> GetAllAsync([FromQuery] AnexoDevGetAllEntity payload)

        {
            Response<List<AnexoDevDTO>> result = null;
            try
            {
                result = await _AnexoDevRepository.GetAllPaginateAsync(payload.page, payload.limit);
            }
            catch (System.Exception e)
            {
                return BadRequest(new Response<string>
                {
                    Message = "Erro ao buscar os AnexoDevs",
                    Data = e.Message,
                    Success = false,
                    StatusCode = 400

                });

            }
            return Ok(result);
        }

        [HttpGet("{id}")]
        [Authorize]
        public async Task<ActionResult<Response<AnexoDev>>> getById(int id)
        {
            Response<AnexoDevDTO> response = null;

            try
            {
                AnexoDevDTO result = await this._AnexoDevRepository.GetById(id);
                if (result != null)
                {
                    response = new Response<AnexoDevDTO>
                    {
                        Message = "AnexoDev encontrado com sucesso",
                        Data = result,
                        Success = true,
                        StatusCode = 200
                    };
                }
                else
                {
                    response = new Response<AnexoDevDTO>
                    {
                        Message = "AnexoDev não encontrado",
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
                    Message = "Erro ao buscar o AnexoDev",
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
        public async Task<ActionResult<Response<bool>>> create(AnexoDev AnexoDev)
        {
            Response<bool> response = null;

            try
            {
                var result = await this._AnexoDevRepository.Create(AnexoDev);
                if (result)
                {
                    response = new Response<bool>
                    {
                        Message = "AnexoDev criada com sucesso",
                        Data = result,
                        Success = true,
                        StatusCode = 200
                    };
                }
                else
                {
                    response = new Response<bool>
                    {
                        Message = "AnexoDev não criado",
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
                    Message = "Erro ao criar o AnexoDev",
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
        public async Task<ActionResult<Response<bool>>> update(AnexoDev AnexoDev)
        {
            Response<bool> response = null;
            try
            {
                var result = await this._AnexoDevRepository.Update(AnexoDev);
                if (result)
                {
                    response = new Response<bool>
                    {
                        Message = "AnexoDev atualizado com sucesso",
                        Data = result,
                        Success = true,
                        StatusCode = 200
                    };
                }
                else
                {
                    response = new Response<bool>
                    {
                        Message = "AnexoDev não atualizado",
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
                    Message = "Erro ao atualizar o AnexoDev",
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
                var result = await this._AnexoDevRepository.Delete(id);
                if (result)
                {
                    response = new Response<bool>
                    {
                        Message = "AnexoDev excluido com sucesso",
                        Data = result,
                        Success = true,
                        StatusCode = 200
                    };
                }
                else
                {
                    response = new Response<bool>
                    {
                        Message = "AnexoDev não excluido",
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
                    Message = "Erro ao excluir o AnexoDev",
                    Data = e.Message,
                    Success = false,
                    StatusCode = 400
                });
            }
        }


    }

}
