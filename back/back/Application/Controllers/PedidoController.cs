using System.Collections.Generic;
using System.Threading.Tasks;
using back.data.entities.Request;
using back.data.entities.RequestItem;
using back.data.http;
using back.domain.DTO.Request;
using back.domain.entities;
using back.domain.Repositories;
using back.infra.Data.Utils;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace back.Application.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PedidoController : ControllerBase
    {
        private IPedidoRepository _PedidoRepository;


        public PedidoController(IPedidoRepository PedidoRepository)
        {

            _PedidoRepository = PedidoRepository;
        }

        [HttpGet]
        [Authorize]
        public async Task<ActionResult<IResponse<List<PedidoDTO>>>> GetAllAsync([FromQuery] PedidoItemGetAllEntity payload)

        {
            var response = new Response<List<PedidoDTO>>();
            try
            {
                var result = await _PedidoRepository.GetAllPaginateAsync(payload.page, payload.limit);
                response.SetConfig(200);
                response.Data = result.Data;
                response.setHttpAtr(result);
            }
            catch (System.Exception e)
            {
                response.SetConfig(400, "Erro ao buscar os Pedidos" + InnerExceptionMessage.InnerExceptionError(e), false);
            }
            return response.GetResponse();
        }

        [HttpGet("{id}")]
        [Authorize]
        public async Task<ActionResult<IResponse<PedidoDTO>>> getById(int id)
        {
            var response = new Response<PedidoDTO>();

            try
            {
                PedidoDTO result = await this._PedidoRepository.GetById(id);
                if (result != null)
                {
                    response.SetConfig(200);
                    response.Data = result;
                }
                else
                {
                    response.SetConfig(404, "Pedido não encontrado", false);
                }
            }
            catch (System.Exception e)
            {
                response.SetConfig(400, "Erro ao buscar o Pedido" + InnerExceptionMessage.InnerExceptionError(e), false);
            }
            return response.GetResponse();
        }

        [HttpPost]
        [Authorize]
        [Route("Create")]
        public async Task<ActionResult<IResponse<bool>>> create(Pedido Pedido)
        {
            var response = new Response<bool>();

            try
            {
                var result = await this._PedidoRepository.Create(Pedido);
                if (result)
                {
                    response.SetConfig(200);
                    response.Data = result;
                }
                else
                {
                    response.SetConfig(404, "Pedido não criado", false);
                }
            }
            catch (System.Exception e)
            {
                response.SetConfig(400, "Erro ao criar o pedido" + InnerExceptionMessage.InnerExceptionError(e), false);
            }
            return response.GetResponse();
        }

        [HttpPost()]
        [Route("Update")]
        [Authorize]
        public async Task<ActionResult<IResponse<bool>>> update(Pedido Pedido)
        {
            var response = new Response<bool>();
            try
            {
                var result = await this._PedidoRepository.Update(Pedido);
                if (result)
                {
                    response.SetConfig(200);
                    response.Data = result;
                }
                else
                {
                    response.SetConfig(404, "Pedido não atualizado", false);
                }
            }
            catch (System.Exception e)
            {
                response.SetConfig(400, "Erro ao atualizar o pedido" + InnerExceptionMessage.InnerExceptionError(e), false);
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
                var result = await this._PedidoRepository.Delete(id);
                if (result)
                {
                    response.SetConfig(200);
                    response.Data = result;
                }
                else
                {
                    response.SetConfig(404, "Pedido não excluído", false);
                }
            }
            catch (System.Exception e)
            {
                response.SetConfig(400, "Erro ao excluir o pedido" + InnerExceptionMessage.InnerExceptionError(e), false);
            }
            return response.GetResponse();
        }


    }

}
