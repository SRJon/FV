using System.Collections.Generic;
using System.Threading.Tasks;
using back.data.entities.Screen;
using back.data.http;
using back.domain.DTO.ScreenDTO;
using back.domain.Repositories;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace back.Application.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TelaController : ControllerBase
    {

        private ITelaRepository _telaRepository;

        public TelaController(ITelaRepository telaRepository)
        {
            _telaRepository = telaRepository;
        }
        [HttpGet]
        [AllowAnonymous]
        public async Task<ActionResult<Response<List<Tela>>>> GetAllAsync([FromQuery] ScreenGetAllEntity payload)
        {
            Response<List<TelaDTO>> result = null;
            try
            {
                result = await _telaRepository.GetAllPaginateAsync(payload.page, payload.limit);
            }
            catch (System.Exception e)
            {
                return BadRequest(new Response<string>
                {
                    Message = "Erro ao buscar as telas",
                    Data = e.Message,
                    Success = false,
                    StatusCode = 400

                });

            }
            return Ok(result);
        }


        [HttpGet("{id}")]
        [AllowAnonymous]
        public async Task<ActionResult<Response<Tela>>> getById(int id)
        {
            Response<TelaDTO> response = null;

            try
            {
                TelaDTO result = await this._telaRepository.GetById(id);
                if (result != null)
                {
                    response = new Response<TelaDTO>
                    {
                        Message = "Tela encontrada com sucesso",
                        Data = result,
                        Success = true,
                        StatusCode = 200
                    };
                }
                else
                {
                    response = new Response<TelaDTO>
                    {
                        Message = "Tela não encontrada",
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
                    Message = "Erro ao buscar a tela",
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
        public async Task<ActionResult<Response<bool>>> create(Tela tela)
        {

            Response<bool> response = null;
            try
            {
                var result = await this._telaRepository.Create(tela);

                if (result)
                {
                    response = new Response<bool>
                    {
                        Message = "Tela criada com sucesso",
                        Data = result,
                        Success = true,
                        StatusCode = 200
                    };
                }
                else
                {
                    response = new Response<bool>
                    {
                        Message = "Tela não criada",
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
                    Message = "Erro ao criar a tela",
                    Data = e.Message,
                    Success = false,
                    StatusCode = 400
                });
            }


            return Ok(response);
        }


        [HttpPost]
        [Route("Update")]
        [Authorize]
        public async Task<ActionResult<Response<bool>>> update(Tela tela)
        {

            Response<bool> response = null;
            try
            {
                var result = await this._telaRepository.Update(tela);

                if (result)
                {
                    response = new Response<bool>
                    {
                        Message = "Tela atualizada com sucesso",
                        Data = result,
                        Success = true,
                        StatusCode = 200
                    };
                }
                else
                {
                    response = new Response<bool>
                    {
                        Message = "Tela não atualizada",
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
                    Message = "Erro ao atualizar a tela",
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
                var result = await this._telaRepository.Delete(id);

                if (result)
                {
                    response = new Response<bool>
                    {
                        Message = "Tela excluida com sucesso",
                        Data = result,
                        Success = true,
                        StatusCode = 200
                    };
                }
                else
                {
                    response = new Response<bool>
                    {
                        Message = "Tela não excluida",
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
                    Message = "Erro ao excluir a tela",
                    Data = e.Message,
                    Success = false,
                    StatusCode = 400
                });
            }
        }

    }
}