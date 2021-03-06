using System.Collections.Generic;
using System.Threading.Tasks;
using back.data.entities.Parametro;
using back.data.entities.Enterprise;
using back.data.http;
using back.domain.DTO.Parametro;
using back.domain.Repositories;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using back.domain.entities;
using back.infra.Data.Utils;

namespace back.Application.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ParametroController : ControllerBase
    {
        private IParametroRepository _ParametroRepository;


        public ParametroController(IParametroRepository ParametroRepository)
        {

            _ParametroRepository = ParametroRepository;
        }

        [HttpGet]
        [Authorize]
        public async Task<ActionResult<IResponse<List<ParametroDTO>>>> GetAllAsync([FromQuery] ParametroGetAllEntity payload)

        {
            var response = new Response<List<ParametroDTO>>();
            try
            {
                var result = await _ParametroRepository.GetAllPaginateAsync(payload.page, payload.limit);
                response.SetConfig(200);
                response.Data = result.Data;
                response.setHttpAtr(result);
            }
            catch (System.Exception e)
            {
                response.SetConfig(400, "Erro ao buscar os Parametros" + InnerExceptionMessage.InnerExceptionError(e), false);
            }
            return response.GetResponse();
        }

        [HttpGet("{id}")]
        [Authorize]
        public async Task<ActionResult<IResponse<ParametroDTO>>> getById(int id)
        {
            var response = new Response<ParametroDTO>();

            try
            {
                ParametroDTO result = await this._ParametroRepository.GetById(id);
                if (result != null)
                {
                    response.SetConfig(200);
                    response.Data = result;
                }
                else
                {
                    response.SetConfig(404, "Parametro n??o encontrado");
                }
            }
            catch (System.Exception e)
            {
                response.SetConfig(400, "Erro ao buscar o parametro" + InnerExceptionMessage.InnerExceptionError(e));
            }
            return response.GetResponse();
        }

        [HttpPost]
        [Authorize]
        [Route("Create")]
        public async Task<ActionResult<IResponse<bool>>> create(Parametro Parametro)
        {
            var response = new Response<bool>();
            try
            {
                var result = await this._ParametroRepository.Create(Parametro);
                if (result)
                {
                    response.SetConfig(200);
                    response.Data = result;
                }
                else
                {
                    response.SetConfig(404, "Parametro n??o criado", false);
                }
            }
            catch (System.Exception e)
            {
                response.SetConfig(400, "Erro ao criar o parametro" + InnerExceptionMessage.InnerExceptionError(e), false);
            }
            return response.GetResponse();
        }

        [HttpPost()]
        [Route("Update")]
        [Authorize]
        public async Task<ActionResult<IResponse<bool>>> update(Parametro Parametro)
        {
            var response = new Response<bool>();
            try
            {
                var result = await this._ParametroRepository.Update(Parametro);
                if (result)
                {
                    response.SetConfig(200);
                    response.Data = result;
                }
                else
                {
                    response.SetConfig(404, "Parametro n??o atualizado", false);
                }
            }
            catch (System.Exception e)
            {
                response.SetConfig(400, "Erro ao atualizar o Parametro" + InnerExceptionMessage.InnerExceptionError(e), false);
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
                var result = await this._ParametroRepository.Delete(id);
                if (result)
                {
                    response.SetConfig(200);
                    response.Data = result;
                }
                else
                {
                    response.SetConfig(404, "Parametro n??o exclu??do", false);
                }
            }
            catch (System.Exception e)
            {
                response.SetConfig(400, "Erro ao excluir o Parametro" + InnerExceptionMessage.InnerExceptionError(e), false);
            }
            return response.GetResponse();
        }


    }

}
