using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using back.data.entities.User;
using back.data.http;
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
        public ActionResult<Usuario> GetById(int id)
        {
            var response = _usuarioRepository.GetByIdAsync(id);

            // var result = new HttpAdapter<Response<Usuario>>(response.StatusCode, response);

            // return result.GetResponse();
            return response;
        }

        [HttpPost]
        [Authorize]
        [Route("Create")]
        public async Task<ActionResult<Response<bool>>> create(Usuario usuario)
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
                    Message = "Erro ao criar a tela",
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
    }
}