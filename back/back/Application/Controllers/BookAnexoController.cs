using System.Collections.Generic;
using System.Threading.Tasks;
using back.data.entities.BookAnexoAmostra;
using back.data.entities.Enterprise;
using back.data.entities.Enterprise.BookAnexoAmostra;
using back.data.http;
using back.domain.DTO.BookAnexo;
using back.domain.entities;
using back.domain.Repositories;
using back.infra.Data.Utils;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace back.Application.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BookAnexoController : ControllerBase
    {
        private IBookAnexoRepository _BookAnexoRepository;


        public BookAnexoController(IBookAnexoRepository BookAnexoRepository)
        {

            _BookAnexoRepository = BookAnexoRepository;
        }

        [HttpGet]
        [Authorize]
        public async Task<ActionResult<IResponse<List<BookAnexoDTO>>>> GetAllAsync([FromQuery] BookAnexoGetAllEntity payload)

        {
            var response = new Response<List<BookAnexoDTO>>();
            try
            {
                var result = await _BookAnexoRepository.GetAllPaginateAsync(payload.page, payload.limit);
                response.SetConfig(200);
                response.Data = result.Data;
                response.setHttpAtr(result);

            }
            catch (System.Exception e)
            {
                response.SetConfig(400, "Erro ao buscar os BookAnexos" + InnerExceptionMessage.InnerExceptionError(e), false);
            }
            return response.GetResponse();
        }

        [HttpGet("{id}")]
        [Authorize]
        public async Task<ActionResult<IResponse<BookAnexoDTO>>> getById(int id)
        {
            var response = new Response<BookAnexoDTO>();

            try
            {
                BookAnexoDTO result = await this._BookAnexoRepository.GetById(id);
                if (result != null)
                {
                    response.SetConfig(200);
                    response.Data = result;
                }
                else
                {
                    response.SetConfig(404, "BookAnexo não encontrado", false);
                }
            }
            catch (System.Exception e)
            {
                response.SetConfig(400, "Erro ao buscar o BookAnexo" + InnerExceptionMessage.InnerExceptionError(e), false);
            }
            return response.GetResponse();
        }

        [HttpPost]
        [Authorize]
        [Route("Create")]
        public async Task<ActionResult<IResponse<bool>>> create(BookAnexo BookAnexo)
        {
            var response = new Response<bool>();
            try
            {
                var result = await this._BookAnexoRepository.Create(BookAnexo);
                if (result)
                {
                    response.SetConfig(200);
                    response.Data = result;
                }
                else
                {
                    response.SetConfig(404, "BookAnexo não criado", false);
                }
            }
            catch (System.Exception e)
            {
                response.SetConfig(400, "Erro ao criar o BookAnexo" + InnerExceptionMessage.InnerExceptionError(e), false);
            }
            return response.GetResponse();

        }

        [HttpPost()]
        [Route("Update")]
        [Authorize]
        public async Task<ActionResult<IResponse<bool>>> update(BookAnexo BookAnexo)
        {
            var response = new Response<bool>();
            try
            {
                var result = await this._BookAnexoRepository.Update(BookAnexo);
                if (result)
                {
                    response.SetConfig(200);
                    response.Data = result;
                }
                else
                {
                    response.SetConfig(404, "BookAnexo não atualizado", false);
                }
            }
            catch (System.Exception e)
            {
                response.SetConfig(400, "Erro ao atualizar o BookAnexo" + InnerExceptionMessage.InnerExceptionError(e), false);
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
                var result = await this._BookAnexoRepository.Delete(id);
                if (result)
                {
                    response.SetConfig(200);
                    response.Data = result;
                }
                else
                {
                    response.SetConfig(404, "BookAnexo não excluido", false);
                }
            }
            catch (System.Exception e)
            {
                response.SetConfig(400, "Erro ao excluir o BookAnexo" + InnerExceptionMessage.InnerExceptionError(e), false);
            }
            return response.GetResponse();
        }


        [HttpGet]
        [Authorize]
        [Route("GetByCodProd")]
        public async Task<ActionResult<IResponse<BookAnexoAmostraDTO>>> getByCodProd(int codProd)
        {
            var response = new Response<BookAnexoAmostraDTO>();

            try
            {
                BookAnexoAmostraDTO result = await this._BookAnexoRepository.GetBycodProdBookAmostra(codProd);
                if (result != null)
                {
                    response.SetConfig(200);
                    response.Data = result;
                }
                else
                {
                    response.SetConfig(404, "BookAnexo não encontrado", false);
                }
            }
            catch (System.Exception e)
            {
                response.SetConfig(400, "Erro ao buscar o BookAnexo" + InnerExceptionMessage.InnerExceptionError(e), false);
            }
            return response.GetResponse();
        }

        [HttpGet]
        [Authorize]
        [Route("GetAllBookAmostra")]
        public async Task<ActionResult<IResponse<List<BookAnexoAmostraDTO>>>> GetAllBookAmostraAsync([FromQuery] BookAnexoGetAllEntity payload)

        {
            var response = new Response<List<BookAnexoAmostraDTO>>();
            try
            {
                var result = await _BookAnexoRepository.GetAllBookAmostra(payload.page, payload.limit);
                response.SetConfig(200);
                response.Data = result.Data;
                response.setHttpAtr(result);

            }
            catch (System.Exception e)
            {
                response.SetConfig(400, "Erro ao buscar o book Amostra" + InnerExceptionMessage.InnerExceptionError(e), false);
            }
            return response.GetResponse();
        }

    }

}
