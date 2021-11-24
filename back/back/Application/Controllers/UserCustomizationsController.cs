using System.Collections.Generic;
using System.Threading.Tasks;
using back.data.entities.UserCustomizations;
using back.data.entities.Enterprise;
using back.data.http;
using back.domain.DTO.UserCustomizations;
using back.domain.Repositories;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using back.domain.entities;
using back.infra.Data.Utils;

namespace back.Application.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserCustomizationsController : ControllerBase
    {
        private IUserCustomizationsRepository _UserCustomizationsRepository;


        public UserCustomizationsController(IUserCustomizationsRepository UserCustomizationsRepository)
        {

            _UserCustomizationsRepository = UserCustomizationsRepository;
        }

        [HttpGet]
        [Authorize]
        public async Task<ActionResult<IResponse<List<UserCustomizationsDTO>>>> GetAllAsync([FromQuery] UserCustomizationsGetAllEntity payload)

        {
            var response = new Response<List<UserCustomizationsDTO>>();
            try
            {
                var result = await _UserCustomizationsRepository.GetAllPaginateAsync(payload.page, payload.limit);
                response.SetConfig(200);
                response.Data = result.Data;
                response.setHttpAtr(result);
            }
            catch (System.Exception e)
            {
                response.SetConfig(400, "Erro ao buscar os UserCustomizations" + InnerExceptionMessage.InnerExceptionError(e), false);

            }
            return response.GetResponse();
        }

        [HttpGet("{id}")]
        [Authorize]
        public async Task<ActionResult<IResponse<UserCustomizationsDTO>>> getById(int id)
        {
            var response = new Response<UserCustomizationsDTO>();

            try
            {
                UserCustomizationsDTO result = await this._UserCustomizationsRepository.GetById(id);
                if (result != null)
                {
                    response.SetConfig(200);
                    response.Data = result;
                }
                else
                {
                    response.SetConfig(404, "UserCustomizations não encontrado", false);
                }
            }
            catch (System.Exception e)
            {
                response.SetConfig(400, "Erro ao buscar o UserCustomizations" + InnerExceptionMessage.InnerExceptionError(e), false);
            }


            return response.GetResponse();
        }

        [HttpPost]
        [Authorize]
        [Route("Create")]
        public async Task<ActionResult<IResponse<bool>>> create(UserCustomizations UserCustomizations)
        {
            var response = new Response<bool>();

            try
            {
                var result = await this._UserCustomizationsRepository.Create(UserCustomizations);
                if (result)
                {
                    response.SetConfig(200);
                    response.Data = result;
                }
                else
                {
                    response.SetConfig(404, "UserCustomizations não criado", false);
                }
            }
            catch (System.Exception e)
            {
                response.SetConfig(400, "Erro ao criar o UserCustomizations" + InnerExceptionMessage.InnerExceptionError(e), false);
            }


            return response.GetResponse();

        }

        [HttpPost()]
        [Route("Update")]
        [Authorize]
        public async Task<ActionResult<IResponse<bool>>> update(UserCustomizations UserCustomizations)
        {
            var response = new Response<bool>();
            try
            {
                var result = await this._UserCustomizationsRepository.Update(UserCustomizations);
                if (result)
                {
                    response.SetConfig(200);
                    response.Data = result;
                }
                else
                {
                    response.SetConfig(404, "UserCustomizations não atualizado", false);
                }
            }
            catch (System.Exception e)
            {
                response.SetConfig(400, "Erro ao atualizar o UserCustomizations" + InnerExceptionMessage.InnerExceptionError(e), false);
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
                var result = await this._UserCustomizationsRepository.Delete(id);
                if (result)
                {
                    response.SetConfig(200);
                    response.Data = result;
                }
                else
                {
                    response.SetConfig(404, "UserCustomizations não excluido", false);
                }
            }
            catch (System.Exception e)
            {
                response.SetConfig(400, "Erro ao excluir o UserCustomizations" + InnerExceptionMessage.InnerExceptionError(e), false);
            }
            return response.GetResponse();
        }


    }

}
