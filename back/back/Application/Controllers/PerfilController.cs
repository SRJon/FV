using System.Collections.Generic;
using System.Threading.Tasks;
using back.data.entities.Profile;
using back.data.http;
using back.domain.DTO.ProfileDTO;
using back.domain.Repositories;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace back.Application.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PerfilController : ControllerBase
    {
        private IPerfilRepository _perfilRepository;

        public PerfilController(IPerfilRepository perfilRepository)
        {
            _perfilRepository = perfilRepository;
        }

        [HttpPost]
        [Authorize]
        [Route("Create")]
        public async Task<ActionResult<Response<bool>>> create(PerfilDTOCreate perfil)
        {
            Response<bool> response = null;
            try
            {
                var result = await this._perfilRepository.Create(perfil);
                if (result)
                {
                    response = new Response<bool>
                    {
                        Message = "Perfil criado com sucesso",
                        Data = result,
                        Success = true,
                        StatusCode = 200
                    };
                }
                else
                {
                    response = new Response<bool>
                    {
                        Message = "Pefil não criado",
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
                    Message = "Erro ao criar a perfil",
                    Data = e.Message,
                    Success = false,
                    StatusCode = 400
                });
            }
            return Ok(response);
        }

        [HttpGet("{id}")]
        [Authorize]
        public async Task<ActionResult<Response<Perfil>>> getById(int id)
        {
            Response<PerfilDTO> response = null;

            try
            {
                PerfilDTO result = await this._perfilRepository.GetById(id);
                if (result != null)
                {
                    response = new Response<PerfilDTO>
                    {
                        Message = "Perfil encontrado com sucesso",
                        Data = result,
                        Success = true,
                        StatusCode = 200
                    };
                }
                else
                {
                    response = new Response<PerfilDTO>
                    {
                        Message = "Perfil não encontrado",
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
                    Message = "Erro ao buscar a perfil",
                    Data = e.Message,
                    Success = false,
                    StatusCode = 400
                });
            }
            return Ok(response);
        }

        [HttpGet]
        [Authorize]
        public async Task<ActionResult<Response<List<Perfil>>>> GetAllAsync([FromQuery] ProfileGetAllEntity payload)
        {
            Response<List<PerfilDTO>> result = null;
            try
            {
                result = await _perfilRepository.GetAllPaginateAsync(payload.page, payload.limit);
            }
            catch (System.Exception e)
            {
                return BadRequest(new Response<string>
                {
                    Message = "Erro ao buscar as perfis",
                    Data = e.Message,
                    Success = false,
                    StatusCode = 400

                });
            }
            return Ok(result);
        }

        [HttpPost]
        [Route("Delete")]
        [Authorize]
        public async Task<ActionResult<Response<bool>>> delete(int id)
        {
            Response<bool> response = null;
            try
            {
                var result = await this._perfilRepository.Delete(id);
                if (result)
                {
                    response = new Response<bool>
                    {
                        Message = "Perfil excluido com sucesso",
                        Data = result,
                        Success = true,
                        StatusCode = 200
                    };
                }
                else
                {
                    response = new Response<bool>
                    {
                        Message = "Perfil não excluido",
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
                    Message = "Erro ao excluir a perfil",
                    Data = e.Message,
                    Success = false,
                    StatusCode = 400
                });
            }
        }

        [HttpPost]
        [Route("Update")]
        [Authorize]
        public async Task<ActionResult<Response<bool>>> update(Perfil perfil)
        {
            Response<bool> response = null;
            try
            {
                var result = await this._perfilRepository.Update(perfil);
                if (result)
                {
                    response = new Response<bool>
                    {
                        Message = "Perfil atualizado com sucesso",
                        Data = result,
                        Success = true,
                        StatusCode = 200
                    };
                }
                else
                {
                    response = new Response<bool>
                    {
                        Message = "Perfil não atualizado",
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
                    Message = "Erro ao atualizar o perfil",
                    Data = e.Message,
                    Success = false,
                    StatusCode = 400
                });
            }
        }
    }
}