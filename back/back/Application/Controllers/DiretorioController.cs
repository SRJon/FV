using System.Collections.Generic;
using System.Threading.Tasks;
using back.data.entities.Diretorio;
using back.data.entities.Enterprise;
using back.data.http;
using back.domain.DTO.Diretorio;
using back.domain.entities;
using back.domain.Repositories;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace back.Application.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class DiretorioController : ControllerBase
    {
        private IDiretorioRepository _DiretorioRepository;


        public DiretorioController(IDiretorioRepository DiretorioRepository)
        {

            _DiretorioRepository = DiretorioRepository;
        }

        [HttpGet]
        [Authorize]
        public async Task<ActionResult<IResponse<List<DiretorioDTO>>>> GetAllAsync([FromQuery] DiretorioGetAllEntity payload)

        {
            var response = new Response<List<DiretorioDTO>>();
            try
            {
                var result = await _DiretorioRepository.GetAllPaginateAsync(payload.page, payload.limit);
                response.SetConfig(200);
                response.Data = result.Data;
                response.setHttpAtr(result);
            }
            catch (System.Exception)
            {
                response.SetConfig(400, "Erro ao buscar os Diretorios", false);
            }
            return response.GetResponse();
        }

        [HttpGet("{id}")]
        [Authorize]
        public async Task<ActionResult<IResponse<DiretorioDTO>>> getById(int id)
        {
            Response<DiretorioDTO> response = null;

            try
            {
                DiretorioDTO result = await this._DiretorioRepository.GetById(id);
                if (result != null)
                {
                    response.SetConfig(200);
                    response.Data = result;
                }
                else
                {
                    response.SetConfig(404, "Diretorio não encontrado", false);
                }
            }
            catch (System.Exception)
            {
                response.SetConfig(400, "Erro ao buscar o Diretório", false);
            }
            return response.GetResponse();
        }

        [HttpPost]
        [Authorize]
        [Route("Create")]
        public async Task<ActionResult<IResponse<bool>>> create(Diretorio Diretorio)
        {
            Response<bool> response = null;

            try
            {
                var result = await this._DiretorioRepository.Create(Diretorio);
                if (result)
                {
                    response.SetConfig(200);
                    response.Data = result;
                }
                else
                {
                    response.SetConfig(404, "Diretorio não criado", false);
                }
            }
            catch (System.Exception)
            {
                response.SetConfig(400, "Erro ao criar o Diretorio", false);
            }
            return response.GetResponse();
        }

        [HttpPost()]
        [Route("Update")]
        [Authorize]
        public async Task<ActionResult<IResponse<bool>>> update(Diretorio Diretorio)
        {
            Response<bool> response = null;
            try
            {
                var result = await this._DiretorioRepository.Update(Diretorio);
                if (result)
                {
                    response.SetConfig(200);
                    response.Data = result;
                }
                else
                {
                    response.SetConfig(404, "Diretorio não atualizado", false);
                }
                return response;
            }
            catch (System.Exception)
            {
                response.SetConfig(400, "Erro ao atualizar o Diretorio", false);
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
                var result = await this._DiretorioRepository.Delete(id);
                if (result)
                {
                    response.SetConfig(200);
                    response.Data = result;
                }
                else
                {
                    response.SetConfig(404, "Diretorio não excluido", false);
                }

            }
            catch (System.Exception)
            {
                response.SetConfig(400, "Erro ao excluir o Diretorio", false);
            }
            return response.GetResponse();
        }


    }

}
