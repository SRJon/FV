using System.Collections.Generic;
using System.Threading.Tasks;
using back.data.entities.VersionDetails;
using back.data.entities.Enterprise;
using back.data.http;
using back.domain.DTO.VersionDetails;
using back.domain.Repositories;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using back.domain.entities;
using back.infra.Data.Utils;

namespace back.Application.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class VersionDetailsController : ControllerBase
    {
        private IVersionDetailsRepository _VersionDetailsRepository;


        public VersionDetailsController(IVersionDetailsRepository VersionDetailsRepository)
        {

            _VersionDetailsRepository = VersionDetailsRepository;
        }

        [HttpGet]
        [Authorize]
        public async Task<ActionResult<IResponse<List<VersionDetailsDTO>>>> GetAllAsync([FromQuery] VersionDetailsGetAllEntity payload)

        {
            var response = new Response<List<VersionDetailsDTO>>();
            try
            {
                var result = await _VersionDetailsRepository.GetAllPaginateAsync(payload.page, payload.limit);
                response.SetConfig(200);
                response.Data = result.Data;
                response.setHttpAtr(result);
            }
            catch (System.Exception e)
            {
                response.SetConfig(400, "Erro ao buscar os VersionDetails" + InnerExceptionMessage.InnerExceptionError(e), false);
            }
            return response.GetResponse();
        }

        [HttpGet("{id}")]
        [Authorize]
        public async Task<ActionResult<IResponse<VersionDetailsDTO>>> getById(int id)
        {
            var response = new Response<VersionDetailsDTO>();
            try
            {
                VersionDetailsDTO result = await this._VersionDetailsRepository.GetById(id);
                if (result != null)
                {
                    response.SetConfig(200);
                    response.Data = result;
                }
                else
                {
                    response.SetConfig(404, "VersionDetails não encontrado", false);
                }
            }
            catch (System.Exception e)
            {
                response.SetConfig(400, "Erro ao buscar o VersionDetails" + InnerExceptionMessage.InnerExceptionError(e), false);
            }
            return response.GetResponse();
        }

        [HttpPost]
        [Authorize]
        [Route("Create")]
        public async Task<ActionResult<IResponse<bool>>> create(VersionDetails VersionDetails)
        {
            var response = new Response<bool>();
            try
            {
                var result = await this._VersionDetailsRepository.Create(VersionDetails);
                if (result)
                {
                    response.SetConfig(200);
                    response.Data = result;
                }
                else
                {
                    response.SetConfig(404, "VersionDetails não criado", false);
                }
            }
            catch (System.Exception e)
            {
                response.SetConfig(400, "Erro ao criar o VersionDetails" + InnerExceptionMessage.InnerExceptionError(e), false);
            }
            return response.GetResponse();
        }

        [HttpPost()]
        [Route("Update")]
        [Authorize]
        public async Task<ActionResult<IResponse<bool>>> update(VersionDetails VersionDetails)
        {
            var response = new Response<bool>();
            try
            {
                var result = await this._VersionDetailsRepository.Update(VersionDetails);
                if (result)
                {
                    response.SetConfig(200);
                    response.Data = result;
                }
                else
                {
                    response.SetConfig(404, "VersionDetails não atualizado", false);
                }
            }
            catch (System.Exception e)
            {
                response.SetConfig(400, "Erro ao atualizar o VersionDetails" + InnerExceptionMessage.InnerExceptionError(e), false);
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
                var result = await this._VersionDetailsRepository.Delete(id);
                if (result)
                {
                    response.SetConfig(200);
                    response.Data = result;
                }
                else
                {
                    response.SetConfig(404, "VersionDetails não excluido", false);
                }
            }
            catch (System.Exception e)
            {
                response.SetConfig(400, "Erro ao excluir o VersionDetails" + InnerExceptionMessage.InnerExceptionError(e), false);
            }
            return response.GetResponse();
        }


    }

}
