using System.Collections.Generic;
using System.Threading.Tasks;
using back.data.entities.Enterprise;
using back.data.entities.Pedido;
using back.data.http;
using back.domain.DTO.Pedido;
using back.domain.Repositories;
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
        public async Task<ActionResult<Response<List<Pedido>>>> GetAllAsync([FromQuery] PedidoItemGetAllEntity payload)

        {
            Response<List<PedidoDTO>> result = null;
            try
            {
                result = await _PedidoRepository.GetAllPaginateAsync(payload.page, payload.limit);
            }
            catch (System.Exception e)
            {
                return BadRequest(new Response<string>
                {
                    Message = "Erro ao buscar os Pedidos",
                    Data = e.Message,
                    Success = false,
                    StatusCode = 400

                });

            }
            return Ok(result);
        }

        [HttpGet("{id}")]
        [Authorize]
        public async Task<ActionResult<Response<Pedido>>> getById(int id)
        {
            Response<PedidoDTO> response = null;

            try
            {
                PedidoDTO result = await this._PedidoRepository.GetById(id);
                if (result != null)
                {
                    response = new Response<PedidoDTO>
                    {
                        Message = "Pedido encontrado com sucesso",
                        Data = result,
                        Success = true,
                        StatusCode = 200
                    };
                }
                else
                {
                    response = new Response<PedidoDTO>
                    {
                        Message = "Pedido não encontrado",
                        Data = null,
                        Success = false,
                        StatusCode = 404
                    };
                }
            }
            catch (System.Exception e)
            {

                return BadRequest(new Response<string>
                {
                    Message = "Erro ao buscar o Pedido",
                    Data = e.Message,
                    Success = false,
                    StatusCode = 400
                });


            }


            return Ok(response);
        }

        [HttpPost]
        [Authorize]
        [Route("Create")]
        public async Task<ActionResult<Response<bool>>> create(Pedido Pedido)
        {
            Response<bool> response = null;

            try
            {
                var result = await this._PedidoRepository.Create(Pedido);
                if (result)
                {
                    response = new Response<bool>
                    {
                        Message = "Pedido criado com sucesso",
                        Data = result,
                        Success = true,
                        StatusCode = 200
                    };
                }
                else
                {
                    response = new Response<bool>
                    {
                        Message = "Pedido não criado",
                        Data = result,
                        Success = false,
                        StatusCode = 404
                    };
                }
            }
            catch (System.Exception e)
            {

                return BadRequest(new Response<string>
                {
                    Message = "Erro ao criar o Pedido",
                    Data = e.Message,
                    Success = false,
                    StatusCode = 400
                });
            }


            return Ok(response);

        }

        [HttpPost()]
        [Route("Update")]
        [Authorize]
        public async Task<ActionResult<Response<bool>>> update(Pedido Pedido)
        {
            Response<bool> response = null;
            try
            {
                var result = await this._PedidoRepository.Update(Pedido);
                if (result)
                {
                    response = new Response<bool>
                    {
                        Message = "Pedido atualizado com sucesso",
                        Data = result,
                        Success = true,
                        StatusCode = 200
                    };
                }
                else
                {
                    response = new Response<bool>
                    {
                        Message = "Pedido não atualizado",
                        Data = result,
                        Success = false,
                        StatusCode = 404
                    };
                }
                return response;
            }
            catch (System.Exception e)
            {
                return BadRequest(new Response<string>
                {
                    Message = "Erro ao atualizar o Pedido",
                    Data = e.Message,
                    Success = false,
                    StatusCode = 400
                });
            }
        }
        [HttpPost]
        [Route("Delete")]
        [Authorize]
        public async Task<ActionResult<Response<bool>>> delete(int id)
        {
            Response<bool> response = null;
            try
            {
                var result = await this._PedidoRepository.Delete(id);
                if (result)
                {
                    response = new Response<bool>
                    {
                        Message = "Pedido excluido com sucesso",
                        Data = result,
                        Success = true,
                        StatusCode = 200
                    };
                }
                else
                {
                    response = new Response<bool>
                    {
                        Message = "Pedido não excluido",
                        Data = result,
                        Success = false,
                        StatusCode = 404
                    };
                }
                return response;
            }
            catch (System.Exception e)
            {
                return BadRequest(new Response<string>
                {
                    Message = "Erro ao excluir o Pedido",
                    Data = e.Message,
                    Success = false,
                    StatusCode = 400
                });
            }
        }


    }

}
