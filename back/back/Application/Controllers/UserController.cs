using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using back.data.entities.User;
using back.data.http;
using back.domain.DTO.User;
using back.domain.entities;
using back.domain.Repositories;
using back.infra.Data.Utils;
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
        public async Task<ActionResult<IResponse<List<UsuarioDTO>>>> GetAll(int page = 1, int limit = 10)
        {
            var response = new Response<List<UsuarioDTO>>();
            try
            {
                var result = await _usuarioRepository.GetAllPaginateAsync(page, limit);
                response.SetConfig(200);
                response.Data = result.Data;
                response.setHttpAtr(result);
            }
            catch (System.Exception)
            {
                response.SetConfig(400, "Erro ao buscar as telas", false);
            }
            return response.GetResponse();
        }

        [HttpGet]
        [Authorize]
        [Route("{id}")]
        public async Task<ActionResult<Response<UsuarioDTO>>> GetById(int id)
        {

            var response = new Response<UsuarioDTO>();
            try
            {
                UsuarioDTO result = await this._usuarioRepository.GetById(id);
                if (result != null)
                {
                    response.SetConfig(200);
                    response.Data = result;
                }
                else
                {
                    response.SetConfig(404, "Usuário não encontrado", false);
                }
            }
            catch (System.Exception e)
            {
                response.SetConfig(400, "Erro ao buscar usuário" + InnerExceptionMessage.InnerExceptionError(e), false);
            }
            return Ok(response);
        }

        [HttpPost]
        [AllowAnonymous]
        [Route("Create")]
        public async Task<ActionResult<IResponse<bool>>> create(UsuarioDTOCreate usuario)
        {
            var response = new Response<bool>();
            try
            {
                var result = await this._usuarioRepository.Create(usuario);
                if (result)
                {
                    response.SetConfig(200);
                    response.Data = result;
                }
                else
                {
                    response.SetConfig(404, "Usuário não criado", false);
                }
            }
            catch (System.Exception e)
            {
                response.SetConfig(400, "Erro ao criar a usuário: " + e.InnerException.Message.Split("tabela")[0], false);

                response.SetConfig(400, "Erro ao criar a usuário" + InnerExceptionMessage.InnerExceptionError(e), false);

            }
            return response.GetResponse();
        }

        [HttpPost]
        [Route("Update")]
        [Authorize]
        public async Task<ActionResult<IResponse<bool>>> update(UsuarioDTOUpdateDTO usuario)
        {
            var response = new Response<bool>();
            try
            {
                var result = await this._usuarioRepository.Update(usuario);
                if (result)
                {
                    response.SetConfig(200);
                    response.Data = result;
                }
                else
                {
                    response.SetConfig(404, "Usuário não atualizado", false);
                }
            }
            catch (System.Exception e)
            {

                response.SetConfig(400, "Erro ao atualizar o usuário" + InnerExceptionMessage.InnerExceptionError(e), false);

            }
            return response.GetResponse();
        }

        [HttpPost]
        [Route("Delete")]
        [Authorize]
        public async Task<ActionResult<IResponse<bool>>> delete(int id)
        {
            var response = new Response<bool>();
            try
            {
                var result = await this._usuarioRepository.Delete(id);
                if (result)
                {
                    response.SetConfig(200);
                    response.Data = result;
                }
                else
                {
                    response.SetConfig(404, "Usuário não excluído", false);
                }
            }
            catch (System.Exception e)
            {
                response.SetConfig(400, "Erro ao excluir o usuário" + InnerExceptionMessage.InnerExceptionError(e), false);
            }
            return response.GetResponse();
        }
        [HttpGet]
        [Route("GetbyLogin")]
        public async Task<ActionResult<IResponse<UsuarioDTO>>> getByLogin(string login)
        {
            var response = new Response<UsuarioDTO>();
            try
            {
                UsuarioDTO result = await this._usuarioRepository.GetByLogin(login);
                if (result != null)
                {
                    response.SetConfig(200);
                    response.Data = result;
                }
                else
                {
                    response.SetConfig(404, "Usuário não encontrado", false);
                }
            }
            catch (System.Exception e)
            {
                response.SetConfig(400, "Erro ao buscar usuário" + InnerExceptionMessage.InnerExceptionError(e), false);
            }
            return response.GetResponse();

        }
    }
}