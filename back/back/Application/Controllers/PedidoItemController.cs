using System.Collections.Generic;
using System.Threading.Tasks;
using back.data.entities.Enterprise;
using back.data.entities.PedidoItem;
using back.data.http;
using back.domain.DTO.PedidoItem;
using back.domain.entities;
using back.domain.Repositories;
using back.infra.Data.Utils;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace back.Application.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PedidoItemController : ControllerBase
    {
        private IPedidoItemRepository _PedidoItemRepository;


        public PedidoItemController(IPedidoItemRepository PedidoItemRepository)
        {

            _PedidoItemRepository = PedidoItemRepository;
        }

        [HttpGet]
        [Authorize]
        public async Task<ActionResult<IResponse<List<PedidoItemDTO>>>> GetAllAsync([FromQuery] PedidoItemGetAllEntity payload)

        {
            var response = new Response<List<PedidoItemDTO>>();
            try
            {
                var result = await _PedidoItemRepository.GetAllPaginateAsync(payload.page, payload.limit);
                response.SetConfig(200);
                response.Data = result.Data;
                response.setHttpAtr(result);

            }
            catch (System.Exception e)
            {
                response.SetConfig(400, "Erro ao buscar os PedidoItems" + InnerExceptionMessage.InnerExceptionError(e), false);
            }
            return response.GetResponse();
        }

        [HttpGet("{id}")]
        [Authorize]
        public async Task<ActionResult<IResponse<PedidoItemDTO>>> getById(int id)
        {
            var response = new Response<PedidoItemDTO>();
            try
            {
                PedidoItemDTO result = await this._PedidoItemRepository.GetById(id);
                if (result != null)
                {
                    response.SetConfig(200);
                    response.Data = result;
                }
                else
                {
                    response.SetConfig(404, "PedidoItem não encontrado", false);
                }
            }
            catch (System.Exception e)
            {
                response.SetConfig(400, "Erro ao buscar o PedidoItem" + InnerExceptionMessage.InnerExceptionError(e), false);
            }
            return response.GetResponse();
        }

        [HttpPost]
        [Authorize]
        [Route("Create")]
        public async Task<ActionResult<IResponse<bool>>> create(PedidoItem PedidoItem)
        {
            var response = new Response<bool>();

            try
            {
                var result = await this._PedidoItemRepository.Create(PedidoItem);
                if (result)
                {
                    response.SetConfig(200);
                    response.Data = result;
                }
                else
                {
                    response.SetConfig(404, "PedidoItem não criado", false);
                }
            }
            catch (System.Exception e)
            {
                response.SetConfig(400, "Erro ao criar o PedidoItem" + InnerExceptionMessage.InnerExceptionError(e), false);
            }
            return response.GetResponse();
        }

        [HttpPost()]
        [Route("Update")]
        [Authorize]
        public async Task<ActionResult<IResponse<bool>>> update(PedidoItem PedidoItem)
        {
            var response = new Response<bool>();
            try
            {
                var result = await this._PedidoItemRepository.Update(PedidoItem);
                if (result)
                {
                    response.SetConfig(200);
                    response.Data = result;
                }
                else
                {
                    response.SetConfig(404, "PedidoItem não atualizado", false);
                }
                return response;
            }
            catch (System.Exception e)
            {
                response.SetConfig(400, "Erro ao atualizar o PedidoItem" + InnerExceptionMessage.InnerExceptionError(e), false);
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
                var result = await this._PedidoItemRepository.Delete(id);
                if (result)
                {
                    response.SetConfig(200);
                    response.Data = result;
                }
                else
                {
                    response.SetConfig(404, "PedidoItem não excluido", false);
                }
            }
            catch (System.Exception e)
            {
                response.SetConfig(400, "Erro ao excluir o PedidoItem" + InnerExceptionMessage.InnerExceptionError(e), false);
            }
            return response.GetResponse();
        }
    }

}
