using System.Collections.Generic;
using System.Threading.Tasks;
using back.data.entities.BProduto;
using back.data.entities.Enterprise;
using back.data.http;
using back.domain.DTO.BProduto;
using back.domain.Repositories;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace back.Application.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BProdutoController : ControllerBase
    {
        private IBProdutoRepository _BProdutoRepository;


        public BProdutoController(IBProdutoRepository BProdutoRepository)
        {

            _BProdutoRepository = BProdutoRepository;
        }

        [HttpGet]
        [Authorize]
        public async Task<ActionResult<Response<List<BProduto>>>> GetAllAsync([FromQuery] BProdutoGetAllEntity payload)

        {
            Response<List<BProdutoDTO>> result = null;
            try
            {
                result = await _BProdutoRepository.GetAllPaginateAsync(payload.page, payload.limit);
            }
            catch (System.Exception e)
            {
                return BadRequest(new Response<string>
                {
                    Message = "Erro ao buscar os BProdutos",
                    Data = e.Message,
                    Success = false,
                    StatusCode = 400

                });

            }
            return Ok(result);
        }

        [HttpGet("{id}")]
        [Authorize]
        public async Task<ActionResult<Response<BProduto>>> getById(int id)
        {
            Response<BProdutoDTO> response = null;

            try
            {
                BProdutoDTO result = await this._BProdutoRepository.GetById(id);
                if (result != null)
                {
                    response = new Response<BProdutoDTO>
                    {
                        Message = "BProduto encontrado com sucesso",
                        Data = result,
                        Success = true,
                        StatusCode = 200
                    };
                }
                else
                {
                    response = new Response<BProdutoDTO>
                    {
                        Message = "BProduto não encontrado",
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
                    Message = "Erro ao buscar o BProduto",
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
        public async Task<ActionResult<Response<bool>>> create(BProduto BProduto)
        {
            Response<bool> response = null;

            try
            {
                var result = await this._BProdutoRepository.Create(BProduto);
                if (result)
                {
                    response = new Response<bool>
                    {
                        Message = "BProduto criada com sucesso",
                        Data = result,
                        Success = true,
                        StatusCode = 200
                    };
                }
                else
                {
                    response = new Response<bool>
                    {
                        Message = "BProduto não criado",
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
                    Message = "Erro ao criar o BProduto",
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
        public async Task<ActionResult<Response<bool>>> update(BProduto BProduto)
        {
            Response<bool> response = null;
            try
            {
                var result = await this._BProdutoRepository.Update(BProduto);
                if (result)
                {
                    response = new Response<bool>
                    {
                        Message = "BProduto atualizado com sucesso",
                        Data = result,
                        Success = true,
                        StatusCode = 200
                    };
                }
                else
                {
                    response = new Response<bool>
                    {
                        Message = "BProduto não atualizado",
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
                    Message = "Erro ao atualizar o BProduto",
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
                var result = await this._BProdutoRepository.Delete(id);
                if (result)
                {
                    response = new Response<bool>
                    {
                        Message = "BProduto excluido com sucesso",
                        Data = result,
                        Success = true,
                        StatusCode = 200
                    };
                }
                else
                {
                    response = new Response<bool>
                    {
                        Message = "BProduto não excluido",
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
                    Message = "Erro ao excluir o BProduto",
                    Data = e.Message,
                    Success = false,
                    StatusCode = 400
                });
            }
        }


    }

}
