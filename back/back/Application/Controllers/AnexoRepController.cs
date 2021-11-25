using System.Collections.Generic;
using System.Threading.Tasks;
using back.data.entities.AnexoRep;
using back.data.entities.Enterprise;
using back.data.http;
using back.domain.DTO.AnexoRep;
using back.domain.entities;
using back.domain.Repositories;
using back.infra.Data.Utils;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace back.Application.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AnexoRepController : ControllerBase
    {
        private IAnexoRepRepository _AnexoRepRepository;


        public AnexoRepController(IAnexoRepRepository AnexoRepRepository)
        {

            _AnexoRepRepository = AnexoRepRepository;
        }

        [HttpGet]
        [Authorize]
        public async Task<ActionResult<IResponse<List<AnexoRepDTO>>>> GetAllAsync([FromQuery] AnexoRepGetAllEntity payload)

        {
            var response = new Response<List<AnexoRepDTO>>();
            try
            {
                var result = await _AnexoRepRepository.GetAllPaginateAsync(payload.page, payload.limit);
                response.SetConfig(200);
                response.Data = result.Data;
                response.setHttpAtr(result);
            }
            catch (System.Exception e)
            {
                response.SetConfig(400, "Erro ao buscar os AnexosReps" + InnerExceptionMessage.InnerExceptionError(e), false);
            }
            return response.GetResponse();
        }

        [HttpGet("{id}")]
        [Authorize]
        public async Task<ActionResult<IResponse<AnexoRepDTO>>> getById(int id)
        {
            var response = new Response<AnexoRepDTO>();

            try
            {
                AnexoRepDTO result = await this._AnexoRepRepository.GetById(id);
                if (result != null)
                {
                    response.SetConfig(200);
                    response.Data = result;
                }
                else
                {
                    response.SetConfig(404, "AnexoRep não encontrado", false);
                }
            }
            catch (System.Exception e)
            {
                response.SetConfig(400, "Erro ao buscar o AnexoRep" + InnerExceptionMessage.InnerExceptionError(e), false);
            }
            return response.GetResponse();
        }

        [HttpPost]
        [Authorize]
        [Route("Create")]
        public async Task<ActionResult<IResponse<bool>>> create(AnexoRep AnexoRep)
        {
            var response = new Response<bool>();
            try
            {
                var result = await this._AnexoRepRepository.Create(AnexoRep);
                if (result)
                {
                    response.SetConfig(200);
                    response.Data = result;
                }
                else
                {
                    response.SetConfig(404, "AnexoRep não criado", false);
                }
            }
            catch (System.Exception e)
            {
                response.SetConfig(400, "Erro ao criar o AnexoRep" + InnerExceptionMessage.InnerExceptionError(e), false);
            }
            return response.GetResponse();
        }

        [HttpPost()]
        [Route("Update")]
        [Authorize]
        public async Task<ActionResult<IResponse<bool>>> update(AnexoRep AnexoRep)
        {
            var response = new Response<bool>();
            try
            {
                var result = await this._AnexoRepRepository.Update(AnexoRep);
                if (result)
                {
                    response.SetConfig(200);
                    response.Data = result;
                }
                else
                {
                    response.SetConfig(404, "AnexoRep não atualizado", false);
                }
            }
            catch (System.Exception e)
            {
                response.SetConfig(400, "Erro ao atualizar o AnexoRep" + InnerExceptionMessage.InnerExceptionError(e), false);
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
                var result = await this._AnexoRepRepository.Delete(id);
                if (result)
                {
                    response.SetConfig(200);
                    response.Data = result;
                }
                else
                {
                    response.SetConfig(404, "AnexoRep não excluido", false);
                }
            }
            catch (System.Exception e)
            {
                response.SetConfig(400, "Erro ao excluir o AnexoRep" + InnerExceptionMessage.InnerExceptionError(e), false);
            }
            return response.GetResponse();
        }
    }

}
