using System.Collections.Generic;
using System.Threading.Tasks;
using back.data.entities.Projetos;
using back.data.entities.Enterprise;
using back.data.http;
using back.domain.DTO.Projetos;
using back.domain.Repositories;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace back.Application.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProjetosController : ControllerBase
    {
        private IProjetosRepository _ProjetosRepository;


        public ProjetosController(IProjetosRepository ProjetosRepository)
        {

            _ProjetosRepository = ProjetosRepository;
        }

        [HttpGet]
        [Authorize]
        public async Task<ActionResult<Response<List<Projetos>>>> GetAllAsync([FromQuery] ProjetosGetAllEntity payload)

        {
            Response<List<ProjetosDTO>> result = null;
            try
            {
                result = await _ProjetosRepository.GetAllPaginateAsync(payload.page, payload.limit);
            }
            catch (System.Exception e)
            {
                return BadRequest(new Response<string>
                {
                    Message = "Erro ao buscar os Projetoss",
                    Data = e.Message,
                    Success = false,
                    StatusCode = 400

                });

            }
            return Ok(result);
        }

        [HttpGet("{id}")]
        [Authorize]
        public async Task<ActionResult<Response<Projetos>>> getById(int id)
        {
            Response<ProjetosDTO> response = null;

            try
            {
                ProjetosDTO result = await this._ProjetosRepository.GetById(id);
                if (result != null)
                {
                    response = new Response<ProjetosDTO>
                    {
                        Message = "Projetos encontrado com sucesso",
                        Data = result,
                        Success = true,
                        StatusCode = 200
                    };
                }
                else
                {
                    response = new Response<ProjetosDTO>
                    {
                        Message = "Projetos não encontrado",
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
                    Message = "Erro ao buscar o Projetos",
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
        public async Task<ActionResult<Response<bool>>> create(Projetos Projetos)
        {
            Response<bool> response = null;

            try
            {
                var result = await this._ProjetosRepository.Create(Projetos);
                if (result)
                {
                    response = new Response<bool>
                    {
                        Message = "Projetos criada com sucesso",
                        Data = result,
                        Success = true,
                        StatusCode = 200
                    };
                }
                else
                {
                    response = new Response<bool>
                    {
                        Message = "Projetos não criado",
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
                    Message = "Erro ao criar o Projetos",
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
        public async Task<ActionResult<Response<bool>>> update(Projetos Projetos)
        {
            Response<bool> response = null;
            try
            {
                var result = await this._ProjetosRepository.Update(Projetos);
                if (result)
                {
                    response = new Response<bool>
                    {
                        Message = "Projetos atualizado com sucesso",
                        Data = result,
                        Success = true,
                        StatusCode = 200
                    };
                }
                else
                {
                    response = new Response<bool>
                    {
                        Message = "Projetos não atualizado",
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
                    Message = "Erro ao atualizar o Projetos",
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
                var result = await this._ProjetosRepository.Delete(id);
                if (result)
                {
                    response = new Response<bool>
                    {
                        Message = "Projetos excluido com sucesso",
                        Data = result,
                        Success = true,
                        StatusCode = 200
                    };
                }
                else
                {
                    response = new Response<bool>
                    {
                        Message = "Projetos não excluido",
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
                    Message = "Erro ao excluir o Projetos",
                    Data = e.Message,
                    Success = false,
                    StatusCode = 400
                });
            }
        }


    }

}
