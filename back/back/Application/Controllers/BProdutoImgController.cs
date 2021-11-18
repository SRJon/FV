using System.Collections.Generic;
using System.Threading.Tasks;
using back.data.entities.BProdutoImg;
using back.data.entities.Enterprise;
using back.data.http;
using back.domain.DTO.BProdutoImg;
using back.domain.Repositories;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace back.Application.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BProdutoImgController : ControllerBase
    {
        private IBProdutoImgRepository _BProdutoImgRepository;


        public BProdutoImgController(IBProdutoImgRepository BProdutoImgRepository)
        {

            _BProdutoImgRepository = BProdutoImgRepository;
        }

        [HttpGet]
        [Authorize]
        public async Task<ActionResult<Response<List<BProdutoImg>>>> GetAllAsync([FromQuery] BProdutoImgGetAllEntity payload)

        {
            Response<List<BProdutoImgDTO>> result = null;
            try
            {
                result = await _BProdutoImgRepository.GetAllPaginateAsync(payload.page, payload.limit);
            }
            catch (System.Exception e)
            {
                return BadRequest(new Response<string>
                {
                    Message = "Erro ao buscar os BProdutoImgs",
                    Data = e.Message,
                    Success = false,
                    StatusCode = 400

                });

            }
            return Ok(result);
        }

        [HttpGet("{id}")]
        [Authorize]
        public async Task<ActionResult<Response<BProdutoImg>>> getById(int id)
        {
            Response<BProdutoImgDTO> response = null;

            try
            {
                BProdutoImgDTO result = await this._BProdutoImgRepository.GetById(id);
                if (result != null)
                {
                    response = new Response<BProdutoImgDTO>
                    {
                        Message = "BProdutoImg encontrado com sucesso",
                        Data = result,
                        Success = true,
                        StatusCode = 200
                    };
                }
                else
                {
                    response = new Response<BProdutoImgDTO>
                    {
                        Message = "BProdutoImg não encontrado",
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
                    Message = "Erro ao buscar o BProdutoImg",
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
        public async Task<ActionResult<Response<bool>>> create(BProdutoImg BProdutoImg)
        {
            Response<bool> response = null;

            try
            {
                var result = await this._BProdutoImgRepository.Create(BProdutoImg);
                if (result)
                {
                    response = new Response<bool>
                    {
                        Message = "BProdutoImg criada com sucesso",
                        Data = result,
                        Success = true,
                        StatusCode = 200
                    };
                }
                else
                {
                    response = new Response<bool>
                    {
                        Message = "BProdutoImg não criado",
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
                    Message = "Erro ao criar o BProdutoImg",
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
        public async Task<ActionResult<Response<bool>>> update(BProdutoImg BProdutoImg)
        {
            Response<bool> response = null;
            try
            {
                var result = await this._BProdutoImgRepository.Update(BProdutoImg);
                if (result)
                {
                    response = new Response<bool>
                    {
                        Message = "BProdutoImg atualizado com sucesso",
                        Data = result,
                        Success = true,
                        StatusCode = 200
                    };
                }
                else
                {
                    response = new Response<bool>
                    {
                        Message = "BProdutoImg não atualizado",
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
                    Message = "Erro ao atualizar o BProdutoImg",
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
                var result = await this._BProdutoImgRepository.Delete(id);
                if (result)
                {
                    response = new Response<bool>
                    {
                        Message = "BProdutoImg excluido com sucesso",
                        Data = result,
                        Success = true,
                        StatusCode = 200
                    };
                }
                else
                {
                    response = new Response<bool>
                    {
                        Message = "BProdutoImg não excluido",
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
                    Message = "Erro ao excluir o BProdutoImg",
                    Data = e.Message,
                    Success = false,
                    StatusCode = 400
                });
            }
        }


    }

}
