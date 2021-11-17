using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using back.data.entities.User;
using back.data.http;
using back.domain.DTO.Usuario;
using back.domain.Repositories;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace back.Application.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UsuarioController : ControllerBase
    {
        protected readonly IUserRepository _usuarioRepository;


        public UsuarioController(IUserRepository usuarioRepository)
        {
            _usuarioRepository = usuarioRepository;
        }

        [HttpGet]
        [Authorize]
        [Route("/")]
        public async Task<ActionResult<Response<List<Usuario>>>> GetAll(int page = 1, int limit = 10)
        {


            var response = await _usuarioRepository.GetAllPaginateAsync(page, limit);

            var result = new HttpAdapter<Response<List<Usuario>>>(response.StatusCode, response);
            return result.GetResponse();
        }

        [HttpGet]
        [Authorize]
        [Route("/{id}")]
        public async Task<ActionResult<Response<Usuario>>> GetById(int id)
        {

            Response<UsuarioDTO> response = null;
            try
            {
                UsuarioDTO result = await this._usuarioRepository.GetById(id);
                if (result != null)
                {
                    response = new Response<UsuarioDTO>
                    {
                        Message = "Usuário encontrado com sucesso",
                        Data = result,
                        Success = true,
                        StatusCode = 200
                    };
                }
                else
                {
                    response = new Response<UsuarioDTO>
                    {
                        Message = "Usuário não encontrado",
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
        public async Task<ActionResult<Response<bool>>> create(UsuarioDTOCreate usuario)
        {
            Response<bool> response = null;
            try
            {
                var result = await this._usuarioRepository.Create(usuario);
                if (result)
                {
                    response = new Response<bool>
                    {
                        Message = "Usuario criado com sucesso",
                        Data = result,
                        Success = true,
                        StatusCode = 200
                    };
                }
                else
                {
                    response = new Response<bool>
                    {
                        Message = "Usuário não criado",
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
                    Message = "Erro ao criar a usuário",
                    Data = e.Message,
                    Success = false,
                    StatusCode = 400
                });
            }
        }

        [HttpPost]
        [Route("Update")]
        [Authorize]
        public async Task<ActionResult<Response<bool>>> update(Usuario usuario)
        {
            Response<bool> response = null;
            try
            {
                var result = await this._usuarioRepository.Update(usuario);
                if (result)
                {
                    response = new Response<bool>
                    {
                        Message = "Usuário atualizado com sucesso",
                        Data = result,
                        Success = true,
                        StatusCode = 200
                    };
                }
                else
                {
                    response = new Response<bool>
                    {
                        Message = "Usuário não atualizado",
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
                    Message = "Erro ao atualizar o usuário",
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
                var result = await this._usuarioRepository.Delete(id);
                if (result)
                {
                    response = new Response<bool>
                    {
                        Message = "Usuário excluído com sucesso",
                        Data = result,
                        Success = true,
                        StatusCode = 200
                    };
                }
                else
                {
                    response = new Response<bool>
                    {
                        Message = "Usuário não excluído",
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
                    Message = "Erro ao excluir o usuário",
                    Data = e.Message,
                    Success = false,
                    StatusCode = 400
                });
            }
        }
        [HttpGet]
        [Route("GetbyLogin")]
        public async Task<ActionResult<Response<Usuario>>> getByLogin(string login)
        {
            Response<UsuarioDTO> response = null;
            try
            {
                UsuarioDTO result = await this._usuarioRepository.GetByLogin(login);
                if (result != null)
                {
                    response = new Response<UsuarioDTO>
                    {
                        Message = "Usuário encontrado com sucesso",
                        Data = result,
                        Success = true,
                        StatusCode = 200
                    };
                }
                else
                {
                    response = new Response<UsuarioDTO>
                    {
                        Message = "Usuário não encontrado",
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
    }
}