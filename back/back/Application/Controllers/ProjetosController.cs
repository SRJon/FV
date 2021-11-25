using System.Collections.Generic;
using System.Threading.Tasks;
using back.data.entities.Projetos;
using back.data.entities.Enterprise;
using back.data.http;
using back.domain.DTO.Projetos;
using back.domain.Repositories;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using back.domain.entities;
using back.infra.Data.Utils;

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
        public async Task<ActionResult<IResponse<List<ProjetosDTO>>>> GetAllAsync([FromQuery] ProjetosGetAllEntity payload)

        {
            var response = new Response<List<ProjetosDTO>>();
            try
            {
                var result = await _ProjetosRepository.GetAllPaginateAsync(payload.page, payload.limit);
                response.SetConfig(200);
                response.Data = result.Data;
                response.setHttpAtr(result);
            }
            catch (System.Exception e)
            {
                response.SetConfig(400, "Erro ao buscar os Projetos" + InnerExceptionMessage.InnerExceptionError(e), false);
            }
            return response.GetResponse();
        }

        [HttpGet("{id}")]
        [Authorize]
        public async Task<ActionResult<IResponse<ProjetosDTO>>> getById(int id)
        {
            var response = new Response<ProjetosDTO>();
            try
            {
                var result = await this._ProjetosRepository.GetById(id);
                if (result != null)
                {
                    response.SetConfig(200);
                    response.Data = result;
                }
                else
                {
                    response.SetConfig(404, "Projetos não encontrado", false);
                }
            }
            catch (System.Exception e)
            {
                response.SetConfig(400, "Erro ao buscar o Projetos" + InnerExceptionMessage.InnerExceptionError(e), false);
            }
            return response.GetResponse();
        }

        [HttpPost]
        [Authorize]
        [Route("Create")]
        public async Task<ActionResult<IResponse<bool>>> create(Projetos Projetos)
        {
            var response = new Response<bool>();

            try
            {
                var result = await this._ProjetosRepository.Create(Projetos);
                if (result)
                {
                    response.SetConfig(200);
                    response.Data = result;
                }
                else
                {
                    response.SetConfig(404, "Projetos não criado", false);
                }
            }
            catch (System.Exception e)
            {
                response.SetConfig(400, "Erro ao criar o Projetos" + InnerExceptionMessage.InnerExceptionError(e), false);
            }
            return response.GetResponse();
        }

        [HttpPost()]
        [Route("Update")]
        [Authorize]
        public async Task<ActionResult<IResponse<bool>>> update(Projetos Projetos)
        {
            var response = new Response<bool>();
            try
            {
                var result = await this._ProjetosRepository.Update(Projetos);
                if (result)
                {
                    response.SetConfig(200);
                    response.Data = result;
                }
                else
                {
                    response.SetConfig(404, "Projetos não atualizado", false);
                }
            }
            catch (System.Exception e)
            {
                response.SetConfig(400, "Erro ao atualizar o Projetos" + InnerExceptionMessage.InnerExceptionError(e), false);
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
                var result = await this._ProjetosRepository.Delete(id);
                if (result)
                {
                    response.SetConfig(200);
                    response.Data = result;
                }
                else
                {
                    response.SetConfig(404, "Projetos não excluido", false);
                }
            }
            catch (System.Exception e)
            {
                response.SetConfig(400, "Erro ao excluir o Projetos" + InnerExceptionMessage.InnerExceptionError(e), false);
            }
            return response.GetResponse();
        }


    }

}
