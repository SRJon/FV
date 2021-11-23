using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using back.data.entities.AnexoCont;
using back.data.http;
using back.domain.DTO.AnexoCont;
using back.domain.entities;
using back.domain.Repositories;
using back.MappingConfig;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace back.Application.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AnexoContController : ControllerBase
    {
        private readonly IMapper _mapper;
        private IAnexoContRepository _AnexoContRepository;


        public AnexoContController(IAnexoContRepository AnexoContRepository)
        {
            _mapper = MapperConfig.MapperConfiguration().CreateMapper();
            _AnexoContRepository = AnexoContRepository;
        }

        [HttpGet]
        [Authorize]
        public async Task<ActionResult<IResponse<List<AnexoContDTO>>>> GetAllAsync([FromQuery] AnexoContGetAllEntity payload)
        {
            var response = new Response<List<AnexoContDTO>>();
            try
            {
                var result = await _AnexoContRepository.GetAllPaginateAsync(payload.page, payload.limit);
                response.SetConfig(200);
                response.Data = result.Data;
                response.setHttpAtr(result);
            }
            catch (System.Exception)
            {
                response.SetConfig(404, "Erro ao buscar as AnexoConts", false);
            }
            return response.GetResponse();
        }

        [HttpGet("{id}")]
        [Authorize]
        public async Task<ActionResult<IResponse<AnexoContDTO>>> getById(int id)
        {
            var response = new Response<AnexoContDTO>();

            try
            {
                var result = await this._AnexoContRepository.GetById(id);
                if (result != null)
                {
                    response.SetConfig(200);
                    response.Data = result;
                }
                else
                {
                    response.SetConfig(404, "AnexoCont não encontrado", false);
                }
            }
            catch (System.Exception)
            {
                response.SetConfig(400, "Erro ao buscar a AnexoCont", false);
            }
            return response.GetResponse();
        }

        [HttpPost]
        [Authorize]
        [Route("Create")]
        public async Task<ActionResult<IResponse<bool>>> create(AnexoCont AnexoCont)
        {
            var response = new Response<bool>();

            try
            {
                var result = await this._AnexoContRepository.Create(AnexoCont);
                if (result)
                {
                    response.SetConfig(200);
                    response.Data = result;
                }
                else
                {
                    response.SetConfig(404, "AnexoCont não criado", false);
                    response.Data = result;
                }
            }
            catch (System.Exception)
            {

                response.SetConfig(400, "Erro ao criar a AnexoCont", false);
            }
            return response.GetResponse();
        }

        [HttpPost()]
        [Route("Update")]
        [Authorize]
        public async Task<ActionResult<IResponse<bool>>> update(AnexoCont AnexoCont)
        {
            var response = new Response<bool>();
            try
            {
                var result = await this._AnexoContRepository.Update(AnexoCont);
                if (result)
                {
                    response.SetConfig(200);
                    response.Data = result;
                }
                else
                {
                    response.SetConfig(404, "AnexoCont não atualizado", false);
                }
            }
            catch (System.Exception)
            {
                response.SetConfig(400, "Erro ao atualizar o AnexoCont", false);
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
                var result = await this._AnexoContRepository.Delete(id);
                if (result)
                {
                    response.SetConfig(200);
                    response.Data = result;
                }
                else
                {
                    response.SetConfig(404, "AnexoCont não excluido", false);
                }
            }
            catch (System.Exception)
            {
                response.SetConfig(400, "Erro ao excluir o AnexoCont", false);

            }
            return response.GetResponse();
        }


    }

}
