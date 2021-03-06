using System.Collections.Generic;
using System.Threading.Tasks;
using back.data.entities.AnexoDev;
using back.data.http;
using back.domain.DTO.AnexoDev;
using back.domain.entities;
using back.domain.Repositories;
using back.infra.Data.Utils;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace back.Application.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AnexoDevController : ControllerBase
    {
        private IAnexoDevRepository _AnexoDevRepository;


        public AnexoDevController(IAnexoDevRepository AnexoDevRepository)
        {

            _AnexoDevRepository = AnexoDevRepository;
        }

        [HttpGet]
        [Authorize]
        public async Task<ActionResult<IResponse<List<AnexoDevDTO>>>> GetAllAsync([FromQuery] AnexoDevGetAllEntity payload)

        {
            var response = new Response<List<AnexoDevDTO>>();
            try
            {
                var result = await _AnexoDevRepository.GetAllPaginateAsync(payload.page, payload.limit);
                response.SetConfig(200);
                response.Data = result.Data;
                response.setHttpAtr(result);
            }
            catch (System.Exception e)
            {
                response.SetConfig(400, "Erro ao buscar os AnexoDevs " + InnerExceptionMessage.InnerExceptionError(e), false);
            }
            return response.GetResponse();
        }

        [HttpGet("{id}")]
        [Authorize]
        public async Task<ActionResult<IResponse<AnexoDevDTO>>> getById(int id)
        {
            var response = new Response<AnexoDevDTO>();

            try
            {
                AnexoDevDTO result = await this._AnexoDevRepository.GetById(id);
                if (result != null)
                {
                    response.SetConfig(200);
                    response.Data = result;
                }
                else
                {
                    response.SetConfig(404, "AnexoDev não encontrado", false);
                }
            }
            catch (System.Exception e)
            {
                response.SetConfig(400, "Erro ao buscar o AnexoDev " + InnerExceptionMessage.InnerExceptionError(e), false);
            }
            return response.GetResponse();
        }

        [HttpPost]
        [Authorize]
        [Route("Create")]
        public async Task<ActionResult<IResponse<bool>>> create(AnexoDev AnexoDev)
        {
            var response = new Response<bool>();

            try
            {
                var result = await this._AnexoDevRepository.Create(AnexoDev);
                if (result)
                {
                    response.SetConfig(200);
                    response.Data = result;
                }
                else
                {
                    response.SetConfig(404, "AnexoDev não criado", false);
                }
            }
            catch (System.Exception e)
            {
                response.SetConfig(400, "Erro ao criar o AnexoDev " + InnerExceptionMessage.InnerExceptionError(e), false);
            }


            return response.GetResponse();

        }

        [HttpPost()]
        [Route("Update")]
        [Authorize]
        public async Task<ActionResult<IResponse<bool>>> update(AnexoDev AnexoDev)
        {
            var response = new Response<bool>();
            try
            {
                var result = await this._AnexoDevRepository.Update(AnexoDev);
                if (result)
                {
                    response.SetConfig(200);
                    response.Data = result;
                }
                else
                {
                    response.SetConfig(404, "AnexoDev não atualizado", false);
                }
            }
            catch (System.Exception e)
            {
                response.SetConfig(400, "Erro ao atualizar o AnexoDev" + InnerExceptionMessage.InnerExceptionError(e), false);
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
                var result = await this._AnexoDevRepository.Delete(id);
                if (result)
                {
                    response.SetConfig(200);
                    response.Data = result;
                }
                else
                {
                    response.SetConfig(404, "AnexoDev não excluido", false);
                }
            }
            catch (System.Exception e)
            {
                response.SetConfig(400, "Erro ao excluir o AnexoDev" + InnerExceptionMessage.InnerExceptionError(e), false);
            }
            return response.GetResponse();
        }


    }

}
