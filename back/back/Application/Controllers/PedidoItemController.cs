using System.Collections.Generic;
using System.Threading.Tasks;
using back.data.entities.Enterprise;
using back.data.entities.PedidoItem;
using back.data.http;
using back.domain.DTO.PedidoItem;
using back.domain.Repositories;
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
        public async Task<ActionResult<Response<List<PedidoItem>>>> GetAllAsync([FromQuery] PedidoItemGetAllEntity payload)

        {
            Response<List<PedidoItemDTO>> result = null;
            try
            {
                result = await _PedidoItemRepository.GetAllPaginateAsync(payload.page, payload.limit);
            }
            catch (System.Exception e)
            {
                return BadRequest(new Response<string>
                {
                    Message = "Erro ao buscar os PedidoItems",
                    Data = e.Message,
                    Success = false,
                    StatusCode = 400

                });

            }
            return Ok(result);
        }

        [HttpGet("{id}")]
        [Authorize]
        public async Task<ActionResult<Response<PedidoItem>>> getById(int id)
        {
            Response<PedidoItemDTO> response = null;

            try
            {
                PedidoItemDTO result = await this._PedidoItemRepository.GetById(id);
                if (result != null)
                {
                    response = new Response<PedidoItemDTO>
                    {
                        Message = "PedidoItem encontrado com sucesso",
                        Data = result,
                        Success = true,
                        StatusCode = 200
                    };
                }
                else
                {
                    response = new Response<PedidoItemDTO>
                    {
                        Message = "PedidoItem não encontrado",
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
                    Message = "Erro ao buscar o PedidoItem",
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
        public async Task<ActionResult<Response<bool>>> create(PedidoItem PedidoItem)
        {
            Response<bool> response = null;

            try
            {
                var result = await this._PedidoItemRepository.Create(PedidoItem);
                if (result)
                {
                    response = new Response<bool>
                    {
                        Message = "PedidoItem criado com sucesso",
                        Data = result,
                        Success = true,
                        StatusCode = 200
                    };
                }
                else
                {
                    response = new Response<bool>
                    {
                        Message = "PedidoItem não criado",
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
                    Message = "Erro ao criar o PedidoItem",
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
        public async Task<ActionResult<Response<bool>>> update(PedidoItem PedidoItem)
        {
            Response<bool> response = null;
            try
            {
                var result = await this._PedidoItemRepository.Update(PedidoItem);
                if (result)
                {
                    response = new Response<bool>
                    {
                        Message = "PedidoItem atualizado com sucesso",
                        Data = result,
                        Success = true,
                        StatusCode = 200
                    };
                }
                else
                {
                    response = new Response<bool>
                    {
                        Message = "PedidoItem não atualizado",
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
                    Message = "Erro ao atualizar o PedidoItem",
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
                var result = await this._PedidoItemRepository.Delete(id);
                if (result)
                {
                    response = new Response<bool>
                    {
                        Message = "PedidoItem excluido com sucesso",
                        Data = result,
                        Success = true,
                        StatusCode = 200
                    };
                }
                else
                {
                    response = new Response<bool>
                    {
                        Message = "PedidoItem não excluido",
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
                    Message = "Erro ao excluir o PedidoItem",
                    Data = e.Message,
                    Success = false,
                    StatusCode = 400
                });
            }
        }


    }

}
