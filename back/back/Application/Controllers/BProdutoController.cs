using System.Collections.Generic;
using System.Threading.Tasks;
using back.data.entities.BProduto;
using back.data.entities.Enterprise;
using back.data.http;
using back.domain.DTO.BProduto;
using back.domain.entities;
using back.domain.Repositories;
using back.infra.Data.Utils;
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
        public async Task<ActionResult<IResponse<List<BProdutoDTO>>>> GetAllAsync([FromQuery] BProdutoGetAllEntity payload)
        {
            var response = new Response<List<BProdutoDTO>>();
            try
            {
                var result = await _BProdutoRepository.GetAllPaginateAsync(payload.page, payload.limit);
                response.SetConfig(200);
                response.Data = result.Data;
                response.setHttpAtr(result);
            }
            catch (System.Exception e)
            {
                response.SetConfig(400, "Erro ao buscar os BProdutos" + InnerExceptionMessage.InnerExceptionError(e), false);
            }
            return response.GetResponse();
        }

        [HttpGet("{id}")]
        [Authorize]
        public async Task<ActionResult<IResponse<BProdutoDTO>>> getById(int id)
        {
            var response = new Response<BProdutoDTO>();

            try
            {
                BProdutoDTO result = await this._BProdutoRepository.GetById(id);
                if (result != null)
                {
                    response.SetConfig(200);
                    response.Data = result;
                }
                else
                {
                    response.SetConfig(404, "BProduto não encontrado", false);
                }
            }
            catch (System.Exception e)
            {
                response.SetConfig(400, "Erro ao buscar o BProduto" + InnerExceptionMessage.InnerExceptionError(e), false);
            }
            return response.GetResponse();
        }

        [HttpPost]
        [Authorize]
        [Route("Create")]
        public async Task<ActionResult<IResponse<bool>>> create(BProduto BProduto)
        {
            Response<bool> response = null;
            try
            {
                var result = await this._BProdutoRepository.Create(BProduto);
                if (result)
                {
                    response.SetConfig(200);
                    response.Data = result;
                }
                else
                {
                    response.SetConfig(404, "BProduto não criado", false);
                }
            }
            catch (System.Exception e)
            {
                response.SetConfig(400, "Erro ao criar o BProduto" + InnerExceptionMessage.InnerExceptionError(e), false);
            }
            return response.GetResponse();

        }

        [HttpPost()]
        [Route("Update")]
        [Authorize]
        public async Task<ActionResult<IResponse<bool>>> update(BProduto BProduto)
        {
            Response<bool> response = null;
            try
            {
                var result = await this._BProdutoRepository.Update(BProduto);
                if (result)
                {
                    response.SetConfig(200);
                    response.Data = result;
                }
                else
                {
                    response.SetConfig(404, "BProduto não atualizado", false);
                }
            }
            catch (System.Exception e)
            {
                response.SetConfig(400, "Erro ao atualizar o BProduto" + InnerExceptionMessage.InnerExceptionError(e), false);
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
                var result = await this._BProdutoRepository.Delete(id);
                if (result)
                {
                    response.SetConfig(200);
                    response.Data = result;
                }
                else
                {
                    response.SetConfig(404, "BProduto não excluido", false);
                }
            }
            catch (System.Exception e)
            {
                response.SetConfig(400, "Erro ao excluir o BProduto" + InnerExceptionMessage.InnerExceptionError(e), false);
            }
            return response.GetResponse();
        }


    }

}
