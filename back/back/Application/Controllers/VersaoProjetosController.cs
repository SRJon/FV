using System.Collections.Generic;
using System.Threading.Tasks;
using back.data.entities.VersaoProjetos;
using back.data.entities.Enterprise;
using back.data.http;
using back.domain.DTO.VersaoProjetos;
using back.domain.Repositories;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using back.domain.entities;
using back.infra.Data.Utils;

namespace back.Application.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class VersaoProjetosController : ControllerBase
    {
        private IVersaoProjetosRepository _VersaoProjetosRepository;


        public VersaoProjetosController(IVersaoProjetosRepository VersaoProjetosRepository)
        {

            _VersaoProjetosRepository = VersaoProjetosRepository;
        }

        [HttpGet]
        [Authorize]
        public async Task<ActionResult<IResponse<List<VersaoProjetosDTO>>>> GetAllAsync([FromQuery] VersaoProjetosGetAllEntity payload)

        {
            var response = new Response<List<VersaoProjetosDTO>>();
            try
            {
                var result = await _VersaoProjetosRepository.GetAllPaginateAsync(payload.page, payload.limit);
                response.SetConfig(200);
                response.Data = response.Data;
            }
            catch (System.Exception e)
            {
                response.SetConfig(400, "Erro ao buscar os VersaoProjetos" + InnerExceptionMessage.InnerExceptionError(e), false);
            }
            return response.GetResponse();
        }

        [HttpGet("{id}")]
        [Authorize]
        public async Task<ActionResult<IResponse<VersaoProjetosDTO>>> getById(int id)
        {
            var response = new Response<VersaoProjetosDTO>();
            try
            {
                VersaoProjetosDTO result = await this._VersaoProjetosRepository.GetById(id);
                if (result != null)
                {
                    response.SetConfig(200);
                    response.Data = result;
                }
                else
                {
                    response.SetConfig(404, "VersaoProjetos não encontrado", false);
                }
            }
            catch (System.Exception e)
            {
                response.SetConfig(400, "Erro ao buscar o VersaoProjetos" + InnerExceptionMessage.InnerExceptionError(e), false);
            }
            return response.GetResponse();
        }

        [HttpPost]
        [Authorize]
        [Route("Create")]
        public async Task<ActionResult<IResponse<bool>>> create(VersaoProjetos VersaoProjetos)
        {
            var response = new Response<bool>();

            try
            {
                var result = await this._VersaoProjetosRepository.Create(VersaoProjetos);
                if (result)
                {
                    response.SetConfig(200);
                    response.Data = result;
                }
                else
                {
                    response.SetConfig(404, "VersaoProjetos não criado", false);

                }
            }
            catch (System.Exception e)
            {
                response.SetConfig(400, "Erro ao criar o VersaoProjetos" + InnerExceptionMessage.InnerExceptionError(e), false);
            }
            return response.GetResponse();
        }

        [HttpPost()]
        [Route("Update")]
        [Authorize]
        public async Task<ActionResult<IResponse<bool>>> update(VersaoProjetos VersaoProjetos)
        {
            var response = new Response<bool>();
            try
            {
                var result = await this._VersaoProjetosRepository.Update(VersaoProjetos);
                if (result)
                {
                    response.SetConfig(200);
                    response.Data = result;
                }
                else
                {
                    response.SetConfig(404, "VersaoProjetos não atualizado", false);
                }
            }
            catch (System.Exception e)
            {
                response.SetConfig(400, "Erro ao atualizar o VersaoProjetos" + InnerExceptionMessage.InnerExceptionError(e), false);
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
                var result = await this._VersaoProjetosRepository.Delete(id);
                if (result)
                {
                    response.SetConfig(200);
                    response.Data = result;
                }
                else
                {
                    response.SetConfig(404, "VersaoProjetos não excluido", false);
                }
            }
            catch (System.Exception e)
            {
                response.SetConfig(400, "Erro ao excluir o VersaoProjetos" + InnerExceptionMessage.InnerExceptionError(e), false);
            }
            return response.GetResponse();
        }


    }

}
