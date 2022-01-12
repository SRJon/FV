using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using back.data.entities.Screen;
using back.data.http;
using back.domain.DTO.ProfileScreenDTO;
using back.domain.DTO.ScreenDTO;
using back.domain.DTO.User;
using back.domain.entities;
using back.domain.Repositories;
using back.infra.Data.Utils;
using back.MappingConfig;

using back.infra.Services.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace back.Application.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TelaController : ControllerBase
    {
        private ITelaRepository _telaRepository;
        private IUserRepository _usuarioRepository;
        private IPerfilTelaRepository _perfilTelaRepository;

        public TelaController(ITelaRepository telaRepository, IUserRepository usuarioRepository, IPerfilTelaRepository perfilTelaRepository)
        {
            _telaRepository = telaRepository;
            _usuarioRepository = usuarioRepository;
            _perfilTelaRepository = perfilTelaRepository;
        }
        [HttpGet]
        [Authorize]
        public async Task<ActionResult<IResponse<List<TelaDTO>>>> GetAllAsync([FromQuery] ScreenGetAllEntity payload)
        {
            var response = new Response<List<TelaDTO>>();
            try
            {
                var result = await _telaRepository.GetAllPaginateAsync(payload.page, payload.limit);
                response.SetConfig(200, "");
                response.Data = result.Data;
                response.setHttpAtr(result);
            }
            catch (System.Exception e)
            {
                response.SetConfig(400, "Erro ao buscar as telas" + InnerExceptionMessage.InnerExceptionError(e), false);
            }
            return response.GetResponse();
        }
        [HttpGet("getByToken")]
        [AllowAnonymous]
        public async Task<ActionResult<IResponse<List<TelaDTO>>>> GetAllByUserAsync([FromQuery] ScreenGetAllEntity payload)
        {
            var token = "";
            UsuarioWiTHPerfilDTO user = null;
            if (HttpContext.Request.Headers.ContainsKey("Authorization"))
            {
                token = HttpContext.Request.Headers["Authorization"];
                var id = TokenService.getIdByToken(token.Split("Bearer")[1].Trim());
                user = await _usuarioRepository.GetByIdWithPerfil(id);
            }
            var response = new Response<List<TelaDTO>>();
            try
            {
                var result = new Response<List<TelaDTO>>();
                response.SetConfig(200, "");
                response.Data = new List<TelaDTO>();
                response.setHttpAtr(result);
            }
            catch (System.Exception e)
            {
                response.SetConfig(400, "Erro ao buscar as telas" + InnerExceptionMessage.InnerExceptionError(e), false);
            }
            return response.GetResponse();
        }

        [HttpGet("{id}")]
        [Authorize]
        public async Task<ActionResult<IResponse<TelaDTO>>> getById(int id)
        {
            var response = new Response<TelaDTO>();

            try
            {
                var result = await this._telaRepository.GetById(id);
                if (result != null)
                {
                    response.SetConfig(200);
                    response.Data = result;
                }
                else
                {
                    response.SetConfig(404, "Tela não encontrada", false);
                }
            }
            catch (System.Exception e)
            {
                response.SetConfig(400, "Erro ao buscar a tela" + InnerExceptionMessage.InnerExceptionError(e), false);
            }
            return response.GetResponse();
        }


        [HttpPost]
        [Authorize]
        [Route("Create")]
        public async Task<ActionResult<IResponse<bool>>> create(TelaDTOCreate tela)
        {

            var response = new Response<bool>();
            try
            {
                var result = await this._telaRepository.Create(tela);
                if (result)
                {
                    response.SetConfig(200);
                    response.Data = result;
                }
                else
                {
                    response.SetConfig(404, "Tela não criada", false);
                }
            }
            catch (System.Exception e)
            {
                response.SetConfig(400, "Erro ao criar a tela " + InnerExceptionMessage.InnerExceptionError(e), false);
            }
            return response.GetResponse();
        }


        [HttpPost]
        [Route("Update")]
        [Authorize]
        public async Task<ActionResult<IResponse<bool>>> update(Tela tela)
        {

            var response = new Response<bool>();
            try
            {
                var result = await this._telaRepository.Update(tela);
                if (result)
                {
                    response.SetConfig(200);
                    response.Data = result;
                }
                else
                {
                    response.SetConfig(404, "Tela não atualizado", false);
                }
            }
            catch (System.Exception e)
            {
                response.SetConfig(400, "Erro ao atualizar a tela " + InnerExceptionMessage.InnerExceptionError(e), false);
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
                var result = await this._telaRepository.Delete(id);
                if (result)
                {
                    response.SetConfig(200);
                    response.Data = result;
                }
                else
                {
                    response.SetConfig(404, "Tela não excluida", false);
                }
                return response;
            }
            catch (System.Exception e)
            {
                response.SetConfig(400, "Erro ao excluir a tela" + InnerExceptionMessage.InnerExceptionError(e), false);
            }
            return response.GetResponse();
        }
    }
}