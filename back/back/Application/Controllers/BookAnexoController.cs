using System.Collections.Generic;
using System.Threading.Tasks;
using back.data.entities.BookAnexo;
using back.data.entities.Enterprise;
using back.data.http;
using back.domain.DTO.BookAnexo;
using back.domain.Repositories;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace back.Application.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BookAnexoController : ControllerBase
    {
        private IBookAnexoRepository _BookAnexoRepository;


        public BookAnexoController(IBookAnexoRepository BookAnexoRepository)
        {

            _BookAnexoRepository = BookAnexoRepository;
        }

        [HttpGet]
        [Authorize]
        public async Task<ActionResult<Response<List<BookAnexo>>>> GetAllAsync([FromQuery] BookAnexoGetAllEntity payload)

        {
            Response<List<BookAnexoDTO>> result = null;
            try
            {
                result = await _BookAnexoRepository.GetAllPaginateAsync(payload.page, payload.limit);
            }
            catch (System.Exception e)
            {
                return BadRequest(new Response<string>
                {
                    Message = "Erro ao buscar os BookAnexos",
                    Data = e.Message,
                    Success = false,
                    StatusCode = 400

                });

            }
            return Ok(result);
        }

        [HttpGet("{id}")]
        [Authorize]
        public async Task<ActionResult<Response<BookAnexo>>> getById(int id)
        {
            Response<BookAnexoDTO> response = null;

            try
            {
                BookAnexoDTO result = await this._BookAnexoRepository.GetById(id);
                if (result != null)
                {
                    response = new Response<BookAnexoDTO>
                    {
                        Message = "BookAnexo encontrado com sucesso",
                        Data = result,
                        Success = true,
                        StatusCode = 200
                    };
                }
                else
                {
                    response = new Response<BookAnexoDTO>
                    {
                        Message = "BookAnexo não encontrado",
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
                    Message = "Erro ao buscar o BookAnexo",
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
        public async Task<ActionResult<Response<bool>>> create(BookAnexo BookAnexo)
        {
            Response<bool> response = null;

            try
            {
                var result = await this._BookAnexoRepository.Create(BookAnexo);
                if (result)
                {
                    response = new Response<bool>
                    {
                        Message = "BookAnexo criada com sucesso",
                        Data = result,
                        Success = true,
                        StatusCode = 200
                    };
                }
                else
                {
                    response = new Response<bool>
                    {
                        Message = "BookAnexo não criado",
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
                    Message = "Erro ao criar o BookAnexo",
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
        public async Task<ActionResult<Response<bool>>> update(BookAnexo BookAnexo)
        {
            Response<bool> response = null;
            try
            {
                var result = await this._BookAnexoRepository.Update(BookAnexo);
                if (result)
                {
                    response = new Response<bool>
                    {
                        Message = "BookAnexo atualizado com sucesso",
                        Data = result,
                        Success = true,
                        StatusCode = 200
                    };
                }
                else
                {
                    response = new Response<bool>
                    {
                        Message = "BookAnexo não atualizado",
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
                    Message = "Erro ao atualizar o BookAnexo",
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
                var result = await this._BookAnexoRepository.Delete(id);
                if (result)
                {
                    response = new Response<bool>
                    {
                        Message = "BookAnexo excluido com sucesso",
                        Data = result,
                        Success = true,
                        StatusCode = 200
                    };
                }
                else
                {
                    response = new Response<bool>
                    {
                        Message = "BookAnexo não excluido",
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
                    Message = "Erro ao excluir o BookAnexo",
                    Data = e.Message,
                    Success = false,
                    StatusCode = 400
                });
            }
        }


    }

}
