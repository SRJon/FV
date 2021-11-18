using System.Collections.Generic;
using System.Threading.Tasks;
using back.data.entities.Diretorio;
using back.data.entities.Enterprise;
using back.data.http;
using back.domain.DTO.Diretorio;
using back.domain.Repositories;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace back.Application.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class DiretorioController : ControllerBase
    {
        private IDiretorioRepository _DiretorioRepository;


        public DiretorioController(IDiretorioRepository DiretorioRepository)
        {

            _DiretorioRepository = DiretorioRepository;
        }

        [HttpGet]
        [Authorize]
        public async Task<ActionResult<Response<List<Diretorio>>>> GetAllAsync([FromQuery] DiretorioGetAllEntity payload)

        {
            Response<List<DiretorioDTO>> result = null;
            try
            {
                result = await _DiretorioRepository.GetAllPaginateAsync(payload.page, payload.limit);
            }
            catch (System.Exception e)
            {
                return BadRequest(new Response<string>
                {
                    Message = "Erro ao buscar os Diretorios",
                    Data = e.Message,
                    Success = false,
                    StatusCode = 400

                });

            }
            return Ok(result);
        }

        [HttpGet("{id}")]
        [Authorize]
        public async Task<ActionResult<Response<Diretorio>>> getById(int id)
        {
            Response<DiretorioDTO> response = null;

            try
            {
                DiretorioDTO result = await this._DiretorioRepository.GetById(id);
                if (result != null)
                {
                    response = new Response<DiretorioDTO>
                    {
                        Message = "Diretorio encontrado com sucesso",
                        Data = result,
                        Success = true,
                        StatusCode = 200
                    };
                }
                else
                {
                    response = new Response<DiretorioDTO>
                    {
                        Message = "Diretorio não encontrado",
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
                    Message = "Erro ao buscar o Diretorio",
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
        public async Task<ActionResult<Response<bool>>> create(Diretorio Diretorio)
        {
            Response<bool> response = null;

            try
            {
                var result = await this._DiretorioRepository.Create(Diretorio);
                if (result)
                {
                    response = new Response<bool>
                    {
                        Message = "Diretorio criada com sucesso",
                        Data = result,
                        Success = true,
                        StatusCode = 200
                    };
                }
                else
                {
                    response = new Response<bool>
                    {
                        Message = "Diretorio não criado",
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
                    Message = "Erro ao criar o Diretorio",
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
        public async Task<ActionResult<Response<bool>>> update(Diretorio Diretorio)
        {
            Response<bool> response = null;
            try
            {
                var result = await this._DiretorioRepository.Update(Diretorio);
                if (result)
                {
                    response = new Response<bool>
                    {
                        Message = "Diretorio atualizado com sucesso",
                        Data = result,
                        Success = true,
                        StatusCode = 200
                    };
                }
                else
                {
                    response = new Response<bool>
                    {
                        Message = "Diretorio não atualizado",
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
                    Message = "Erro ao atualizar o Diretorio",
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
                var result = await this._DiretorioRepository.Delete(id);
                if (result)
                {
                    response = new Response<bool>
                    {
                        Message = "Diretorio excluido com sucesso",
                        Data = result,
                        Success = true,
                        StatusCode = 200
                    };
                }
                else
                {
                    response = new Response<bool>
                    {
                        Message = "Diretorio não excluido",
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
                    Message = "Erro ao excluir o Diretorio",
                    Data = e.Message,
                    Success = false,
                    StatusCode = 400
                });
            }
        }


    }

}
