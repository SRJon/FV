using System.Collections.Generic;
using System.Threading.Tasks;
using back.data.entities.BProdutoImg;
using back.data.entities.Enterprise;
using back.data.http;
using back.domain.DTO.BProdutoImg;
using back.domain.entities;
using back.domain.Repositories;
using back.infra.Data.Utils;
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
        public async Task<ActionResult<IResponse<List<BProdutoImgDTO>>>> GetAllAsync([FromQuery] BProdutoImgGetAllEntity payload)
        {
            var response = new Response<List<BProdutoImgDTO>>();
            try
            {
                var result = await _BProdutoImgRepository.GetAllPaginateAsync(payload.page, payload.limit);
                response.SetConfig(200);
                response.Data = result.Data;
                response.setHttpAtr(result);
            }
            catch (System.Exception e)
            {
                response.SetConfig(400, "Erro ao buscar os BProdutoImgs" + InnerExceptionMessage.InnerExceptionError(e), false);
            }
            return response.GetResponse();
        }

        [HttpGet("{id}")]
        [Authorize]
        public async Task<ActionResult<IResponse<BProdutoImgDTO>>> getById(int id)
        {
            var response = new Response<BProdutoImgDTO>();
            try
            {
                BProdutoImgDTO result = await this._BProdutoImgRepository.GetById(id);
                if (result != null)
                {
                    response.SetConfig(200);
                    response.Data = result;
                }
                else
                {
                    response.SetConfig(404, "BProdutoImg não encontrado", false);
                }
            }
            catch (System.Exception e)
            {
                response.SetConfig(400, "Erro ao buscar o BProdutoImg" + InnerExceptionMessage.InnerExceptionError(e), false);
            }
            return response.GetResponse();
        }

        [HttpPost]
        [Authorize]
        [Route("Create")]
        public async Task<ActionResult<IResponse<bool>>> create(BProdutoImg BProdutoImg)
        {
            var response = new Response<bool>();

            try
            {
                var result = await this._BProdutoImgRepository.Create(BProdutoImg);
                if (result)
                {
                    response.SetConfig(200);
                    response.Data = result;
                }
                else
                {
                    response.SetConfig(404, "BProdutoImg não criado", false);

                }
            }
            catch (System.Exception e)
            {
                response.SetConfig(400, "Erro ao criar o BProdutoImg" + InnerExceptionMessage.InnerExceptionError(e), false);
            }
            return response.GetResponse();
        }

        [HttpPost()]
        [Route("Update")]
        [Authorize]
        public async Task<ActionResult<IResponse<bool>>> update(BProdutoImg BProdutoImg)
        {
            var response = new Response<bool>();
            try
            {
                var result = await this._BProdutoImgRepository.Update(BProdutoImg);
                if (result)
                {
                    response.SetConfig(200);
                    response.Data = result;
                }
                else
                {
                    response.SetConfig(404, "BProdutoImg não atualizado", false);

                }
            }
            catch (System.Exception e)
            {
                response.SetConfig(400, "Erro ao atualizar o BProdutoImg" + InnerExceptionMessage.InnerExceptionError(e), false);
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
                var result = await this._BProdutoImgRepository.Delete(id);
                if (result)
                {
                    response.SetConfig(200);
                    response.Data = result;
                }
                else
                {
                    response.SetConfig(404, "BProdutoImg não excluido", false);

                }
            }
            catch (System.Exception e)
            {
                response.SetConfig(400, "Erro ao excluir o BProdutoImg" + InnerExceptionMessage.InnerExceptionError(e), false);
            }
            return response.GetResponse();
        }
    }

}
