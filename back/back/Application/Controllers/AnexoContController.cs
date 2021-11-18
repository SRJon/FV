using System.Collections.Generic;
using System.Threading.Tasks;
using back.data.entities.AnexoCont;
using back.data.http;
using back.domain.DTO.AnexoCont;
using back.domain.Repositories;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace back.Application.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AnexoContController : ControllerBase
    {
        private IAnexoContRepository _AnexoContRepository;


        public AnexoContController(IAnexoContRepository AnexoContRepository)
        {

            _AnexoContRepository = AnexoContRepository;
        }

        [HttpGet]
        [Authorize]
        public async Task<ActionResult<Response<List<AnexoCont>>>> GetAllAsync([FromQuery] AnexoContGetAllEntity payload)

        {
            Response<List<AnexoContDTO>> result = null;
            try
            {
                result = await _AnexoContRepository.GetAllPaginateAsync(payload.page, payload.limit);
            }
            catch (System.Exception e)
            {
                return BadRequest(new Response<string>
                {
                    Message = "Erro ao buscar os AnexoConts",
                    Data = e.Message,
                    Success = false,
                    StatusCode = 400

                });

            }
            return Ok(result);
        }

        [HttpGet("{id}")]
        [Authorize]
        public async Task<ActionResult<Response<AnexoCont>>> getById(int id)
        {
            Response<AnexoContDTO> response = null;

            try
            {
                AnexoContDTO result = await this._AnexoContRepository.GetById(id);
                if (result != null)
                {
                    response = new Response<AnexoContDTO>
                    {
                        Message = "AnexoCont encontrado com sucesso",
                        Data = result,
                        Success = true,
                        StatusCode = 200
                    };
                }
                else
                {
                    response = new Response<AnexoContDTO>
                    {
                        Message = "AnexoCont não encontrado",
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
                    Message = "Erro ao buscar o AnexoCont",
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
        public async Task<ActionResult<Response<bool>>> create(AnexoCont AnexoCont)
        {
            Response<bool> response = null;

            try
            {
                var result = await this._AnexoContRepository.Create(AnexoCont);
                if (result)
                {
                    response = new Response<bool>
                    {
                        Message = "AnexoCont criada com sucesso",
                        Data = result,
                        Success = true,
                        StatusCode = 200
                    };
                }
                else
                {
                    response = new Response<bool>
                    {
                        Message = "AnexoCont não criado",
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
                    Message = "Erro ao criar o AnexoCont",
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
        public async Task<ActionResult<Response<bool>>> update(AnexoCont AnexoCont)
        {
            Response<bool> response = null;
            try
            {
                var result = await this._AnexoContRepository.Update(AnexoCont);
                if (result)
                {
                    response = new Response<bool>
                    {
                        Message = "AnexoCont atualizado com sucesso",
                        Data = result,
                        Success = true,
                        StatusCode = 200
                    };
                }
                else
                {
                    response = new Response<bool>
                    {
                        Message = "AnexoCont não atualizado",
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
                    Message = "Erro ao atualizar o AnexoCont",
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
                var result = await this._AnexoContRepository.Delete(id);
                if (result)
                {
                    response = new Response<bool>
                    {
                        Message = "AnexoCont excluido com sucesso",
                        Data = result,
                        Success = true,
                        StatusCode = 200
                    };
                }
                else
                {
                    response = new Response<bool>
                    {
                        Message = "AnexoCont não excluido",
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
                    Message = "Erro ao excluir o AnexoCont",
                    Data = e.Message,
                    Success = false,
                    StatusCode = 400
                });
            }
        }


    }

}
