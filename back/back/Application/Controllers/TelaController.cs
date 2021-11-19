using System.Collections.Generic;
using System.Threading.Tasks;
using back.data.entities.Screen;
using back.data.http;
using back.domain.DTO.ScreenDTO;
using back.domain.entities;
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
        public async Task<ActionResult<IResponse<List<TelaDTO>>>> GetAllAsync([FromQuery] ScreenGetAllEntity payload)
        {
            var response = new Response<List<TelaDTO>>();
            try
            {
                var result = await _telaRepository.GetAllPaginateAsync(payload.page, payload.limit);
                response.SetConfig(200);
                response.Data = result.Data;
            }
            catch (System.Exception)
            {
                response.SetConfig(400, "Erro ao buscar as telas", false);
            }
            return response.GetResponse();
        }


        [HttpGet("{id}")]
        [AllowAnonymous]
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
            catch (System.Exception)
            {
                response.SetConfig(400, "Erro ao buscar a tela", false);
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
            catch (System.Exception)
            {
                response.SetConfig(400, "Erro ao criar a tela", false);
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
            catch (System.Exception)
            {
                response.SetConfig(400, "Erro ao atualizar a tela", false);
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
            catch (System.Exception)
            {
                response.SetConfig(400, "Erro ao excluir a tela", false);
            }
            return response.GetResponse();
        }
    }
}