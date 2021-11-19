using System.Collections.Generic;
using System.Threading.Tasks;
using back.data.entities.Informativo;
using back.data.entities.Enterprise;
using back.data.http;
using back.domain.DTO.Informativo;
using back.domain.Repositories;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using back.domain.entities;

namespace back.Application.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class InformativoController : ControllerBase
    {
        private IInformativoRepository _InformativoRepository;


        public InformativoController(IInformativoRepository InformativoRepository)
        {

            _InformativoRepository = InformativoRepository;
        }

        [HttpGet]
        [Authorize]
        public async Task<ActionResult<IResponse<List<InformativoDTO>>>> GetAllAsync([FromQuery] InformativoGetAllEntity payload)
        {
            var response = new Response<List<InformativoDTO>>();
            try
            {
                var result = await _InformativoRepository.GetAllPaginateAsync(payload.page, payload.limit);
                response.SetConfig(200);
                response.Data = result.Data;
            }
            catch (System.Exception)
            {
                response.SetConfig(400, "Erro ao buscar os Informativos", false);
            }
            return response.GetResponse();
        }

        [HttpGet("{id}")]
        [Authorize]
        public async Task<ActionResult<IResponse<InformativoDTO>>> getById(int id)
        {
            var response = new Response<InformativoDTO>();
            try
            {
                InformativoDTO result = await this._InformativoRepository.GetById(id);
                if (result != null)
                {
                    response.SetConfig(200);
                    response.Data = result;
                }
                else
                {
                    response.SetConfig(404, "Informativo não encontrado", false);
                }
            }
            catch (System.Exception)
            {
                response.SetConfig(400, "Erro ao buscar o Informativo", false);
            }


            return response.GetResponse();
        }

        [HttpPost]
        [Authorize]
        [Route("Create")]
        public async Task<ActionResult<IResponse<bool>>> create(Informativo Informativo)
        {
            Response<bool> response = null;

            try
            {
                var result = await this._InformativoRepository.Create(Informativo);
                if (result)
                {
                    response.SetConfig(200);
                    response.Data = result;
                }
                else
                {
                    response.SetConfig(404, "Informativo não criado", false);
                }
            }
            catch (System.Exception)
            {
                response.SetConfig(400, "Erro ao criar o Informativo", false);
            }


            return response.GetResponse();

        }

        [HttpPost()]
        [Route("Update")]
        [Authorize]
        public async Task<ActionResult<IResponse<bool>>> update(Informativo Informativo)
        {
            Response<bool> response = null;
            try
            {
                var result = await this._InformativoRepository.Update(Informativo);
                if (result)
                {
                    response.SetConfig(200);
                    response.Data = result;
                }
                else
                {
                    response.SetConfig(404, "Informativo não atualizado", false);
                }
                return response;
            }
            catch (System.Exception)
            {
                response.SetConfig(400, "Erro ao atualizar o Informativo", false);
            }
            return response.GetResponse();
        }
        [HttpPost]
        [Route("Delete")]
        [Authorize]
        public async Task<ActionResult<IResponse<bool>>> delete(int id)
        {
            Response<bool> response = null;
            try
            {
                var result = await this._InformativoRepository.Delete(id);
                if (result)
                {
                    response.SetConfig(200);
                    response.Data = result;
                }
                else
                {
                    response.SetConfig(404, "Informativo não excluido", false);
                }
                return response;
            }
            catch (System.Exception)
            {
                response.SetConfig(400, "Erro ao excluir o Informativo", false);
            }
            return response.GetResponse();
        }


    }

}
