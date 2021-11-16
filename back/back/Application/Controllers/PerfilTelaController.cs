using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using back.data.entities.ProfileScreen;
using back.data.http;
using back.domain.DTO.ProfileScreenDTO;
using back.domain.Repositories;
using back.MappingConfig;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace back.Application.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PerfilTelaController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly IPerfilTelaRepository _perfilTelaRepository;

        public PerfilTelaController(IPerfilTelaRepository perfilTelaRepository)
        {
            this._mapper = MapperConfig.MapperConfiguration().CreateMapper();
            _perfilTelaRepository = perfilTelaRepository;
        }

        [HttpPost]
        [Authorize]
        [Route("Create")]
        public async Task<ActionResult<Response<bool>>> create(PerfilTela perfilTela)
        {
            Response<bool> response = null;
            try
            {
                var result = await this._perfilTelaRepository.Create(perfilTela);
                if (result)
                {
                    response = new Response<bool>
                    {
                        Message = "Perfil tela criada com sucesso",
                        Data = result,
                        Success = true,
                        StatusCode = 200
                    };
                }
                else
                {
                    response = new Response<bool>
                    {
                        Message = "Perfil tela não criada",
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
                    Message = "Erro ao criar a Perfil tela",
                    Data = e.Message,
                    Success = false,
                    StatusCode = 400
                });
            }
            return Ok(response);
        }

        [HttpGet("{id}")]
        [AllowAnonymous]
        public async Task<ActionResult<Response<PerfilTela>>> getById(int id)
        {
            var result = HttpAdapter<PerfilTelaDTO>.getInstance();
            Response<PerfilTelaDTO> response = null;
            try
            {
                var res = await this._perfilTelaRepository.GetById(id);
                result.Response = new Response<PerfilTelaDTO>
                {
                    Data = res,
                    Message = "",
                    StatusCode = 201,
                    Success = true
                };
                if (res != null)
                {
                    response.Data = null;
                    response.StatusCode = 404;
                }
                else
                {
                    response = new Response<PerfilTelaDTO>
                    {
                        Message = "Perfil tela não encontrada",
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
                    Message = "Erro ao buscar o Perfil Tela",
                    Data = e.Message,
                    Success = false,
                    StatusCode = 400
                });
            }

            return Ok(response);
        }

        [HttpGet]
        [AllowAnonymous]
        public async Task<ActionResult<Response<List<PerfilTelaDTO>>>> GetAllAsync([FromQuery] ProfileScreenGetAllEntity payload)
        {
            var result = HttpAdapter<List<PerfilTelaDTO>>.getInstance();
            try
            {
                result.Response = await _perfilTelaRepository.GetAllPaginateAsync(payload.page, payload.limit);
            }
            catch (System.Exception)
            {
                var r = new Response<List<PerfilTelaDTO>>
                {
                    Message = "Erro ao buscar as perfis tela",
                    Data = new List<PerfilTelaDTO>(),
                    Success = false,
                    StatusCode = 400

                };
                result = new HttpAdapter<List<PerfilTelaDTO>>(r);
                return result.GetResponse();
            }
            return result.GetResponse();
        }

        [HttpPost]
        [Route("Update")]
        [Authorize]
        public async Task<ActionResult<Response<bool>>> update(PerfilTela perfilTela)
        {
            Response<bool> response = null;
            try
            {
                var result = await this._perfilTelaRepository.Update(perfilTela);
                if (result)
                {
                    response = new Response<bool>
                    {
                        Message = "Perfil tela atualizado com sucesso",
                        Data = result,
                        Success = true,
                        StatusCode = 200
                    };
                }
                else
                {
                    response = new Response<bool>
                    {
                        Message = "Perfil tela não atualizado",
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
                    Message = "Erro ao atualizar o perfil tela",
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
                var result = await this._perfilTelaRepository.Delete(id);
                if (result)
                {
                    response = new Response<bool>
                    {
                        Message = "Perfil tela excluido com sucesso",
                        Data = result,
                        Success = true,
                        StatusCode = 200
                    };
                }
                else
                {
                    response = new Response<bool>
                    {
                        Message = "Perfil tela não excluido",
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
                    Message = "Erro ao excluir a perfil tela",
                    Data = e.Message,
                    Success = false,
                    StatusCode = 400
                });
            }
        }
    }
}