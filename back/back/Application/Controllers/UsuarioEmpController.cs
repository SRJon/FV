using System.Collections.Generic;
using System.Threading.Tasks;
using back.data.entities.UserEmp;
using back.data.http;
using back.domain.DTO.UserEmp;
using back.domain.entities;
using back.domain.Repositories;
using back.infra.Data.Utils;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace back.Application.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UsuarioEmpController : ControllerBase
    {
        private IUsuarioEmpRepository _UsuarioEmpRepository;


        public UsuarioEmpController(IUsuarioEmpRepository UsuarioEmpRepository)
        {

            _UsuarioEmpRepository = UsuarioEmpRepository;
        }

        [HttpGet]
        [Authorize]
        public async Task<ActionResult<IResponse<List<UsuarioEmpDTO>>>> GetAllAsync([FromQuery] UsuarioEmpGetAllEntity payload)

        {
            var response = new Response<List<UsuarioEmpDTO>>();

            try
            {
                var result = await _UsuarioEmpRepository.GetAllPaginateAsync(payload.page, payload.limit);
                response.SetConfig(200);
                response.Data = result.Data;
                response.setHttpAtr(result);
            }
            catch (System.Exception e)
            {
                response.SetConfig(400, "Erro ao buscar as UsuarioEmps" + InnerExceptionMessage.InnerExceptionError(e), false);
            }
            return response.GetResponse();
        }

        [HttpGet("{id}")]
        [Authorize]
        public async Task<ActionResult<IResponse<UsuarioEmpDTO>>> getById(int id)
        {
            var response = new Response<UsuarioEmpDTO>();

            try
            {
                UsuarioEmpDTO result = await this._UsuarioEmpRepository.GetById(id);
                if (result != null)
                {
                    response.SetConfig(200);
                    response.Data = result;
                }
                else
                {
                    response.SetConfig(404, "UsuarioEmp não encontrada", false);
                }
            }
            catch (System.Exception e)
            {
                response.SetConfig(400, "Erro ao buscar a UsuarioEmp" + InnerExceptionMessage.InnerExceptionError(e), false);
            }
            return response.GetResponse();
        }

        [HttpPost]
        [Authorize]
        [Route("Create")]
        public async Task<ActionResult<IResponse<bool>>> create(UsuarioEmp UsuarioEmp)
        {
            var response = new Response<bool>();

            try
            {
                var result = await this._UsuarioEmpRepository.Create(UsuarioEmp);
                if (result)
                {
                    response.SetConfig(200);
                    response.Data = result;
                }
                else
                {
                    response.SetConfig(404, "UsuarioEmp não criada", false);
                }
            }
            catch (System.Exception e)
            {
                response.SetConfig(400, "Erro ao criar a UsuarioEmp" + InnerExceptionMessage.InnerExceptionError(e), false);
            }
            return response.GetResponse();
        }

        [HttpPost()]
        [Route("Update")]
        [Authorize]
        public async Task<ActionResult<IResponse<bool>>> update(UsuarioEmp UsuarioEmp)
        {
            var response = new Response<bool>();
            try
            {
                var result = await this._UsuarioEmpRepository.Update(UsuarioEmp);
                if (result)
                {
                    response.SetConfig(200);
                    response.Data = result;
                }
                else
                {
                    response.SetConfig(404, "UsuarioEmp não atualizada", false);
                }
            }
            catch (System.Exception e)
            {
                response.SetConfig(400, "Erro ao atualizar a UsuarioEmp" + InnerExceptionMessage.InnerExceptionError(e), false);
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
                var result = await this._UsuarioEmpRepository.Delete(id);
                if (result)
                {
                    response.SetConfig(200);
                    response.Data = result;
                }
                else
                {
                    response.SetConfig(404, "UsuarioEmp não excluida", false);
                }
            }
            catch (System.Exception e)
            {
                response.SetConfig(400, "Erro ao excluir a UsuarioEmp" + InnerExceptionMessage.InnerExceptionError(e), false);
            }
            return response.GetResponse();
        }


    }

}
