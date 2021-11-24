using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using back.data.entities.ProfileScreen;
using back.data.http;
using back.domain.DTO.ProfileScreenDTO;
using back.domain.entities;
using back.domain.Repositories;
using back.infra.Data.Utils;
using back.MappingConfig;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace back.Application.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PerfilTelaController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly IPerfilTelaRepository _perfilTelaRepository;

        public PerfilTelaController(IPerfilTelaRepository perfilTelaRepository)
        {
            this._mapper = MapperConfig.MapperConfiguration().CreateMapper();
            _perfilTelaRepository = perfilTelaRepository;
        }

        [HttpPost]
        [Authorize]
        [Route("Create")]
        public async Task<ActionResult<IResponse<bool>>> create(PerfilTelaDTOCreate perfilTela)
        {
            var response = new Response<bool>();
            try
            {
                var result = await this._perfilTelaRepository.Create(perfilTela);
                if (result)
                {
                    response.SetConfig(200);
                    response.Data = result;
                }
                else
                {
                    response.SetConfig(404, "Perfil tela não criada", false);
                }
            }
            catch (System.Exception e)
            {
                response.SetConfig(400, "Erro ao criar o perfil tela" + InnerExceptionMessage.InnerExceptionError(e), false);
            }
            return response.GetResponse();
        }

        [HttpGet("{id}")]
        [Authorize]
        public async Task<ActionResult<IResponse<PerfilTelaDTO>>> getById(int id)
        {
            var response = new Response<PerfilTelaDTO>();
            try
            {
                var result = await this._perfilTelaRepository.GetById(id);
                if (result != null)
                {
                    response.SetConfig(200);
                    response.Data = result;
                }
                else
                {
                    response.SetConfig(404, "Perfil tela não encontrado", false);
                }
            }
            catch (System.Exception e)
            {
                response.SetConfig(400, "Erro ao buscar a perfil tela" + InnerExceptionMessage.InnerExceptionError(e), false);
            }

            return response.GetResponse();
        }

        [HttpGet]
        [Authorize]
        public async Task<ActionResult<IResponse<List<PerfilTelaDTO>>>> GetAllAsync([FromQuery] ProfileScreenGetAllEntity payload)
        {
            var response = new Response<List<PerfilTelaDTO>>();
            try
            {
                var result = await _perfilTelaRepository.GetAllPaginateAsync(payload.page, payload.limit);
                response.SetConfig(200);
                response.Data = result.Data;
                response.setHttpAtr(result);
            }
            catch (System.Exception e)
            {
                response.SetConfig(404, "Erro ao buscar as perfis tela" + InnerExceptionMessage.InnerExceptionError(e), false);
            }
            return response.GetResponse();
        }

        [HttpPost]
        [Route("Update")]
        [Authorize]
        public async Task<ActionResult<IResponse<bool>>> update(PerfilTelaDTOUpdateDTO perfilTela)
        {
            var response = new Response<bool>();
            try
            {
                var result = await this._perfilTelaRepository.Update(perfilTela);
                if (result)
                {
                    response.SetConfig(200);
                    response.Data = result;
                }
                else
                {
                    response.SetConfig(404, "Perfil tela não atualizado", false);
                }
            }
            catch (System.Exception e)
            {
                response.SetConfig(400, "Erro ao atualizar o Perfil tela" + InnerExceptionMessage.InnerExceptionError(e), false);
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
                var result = await this._perfilTelaRepository.Delete(id);
                if (result)
                {
                    response.SetConfig(200);
                    response.Data = result;
                }
                else
                {
                    response.SetConfig(404, "Perfil tela não excluido", false);
                }
            }
            catch (System.Exception e)
            {
                response.SetConfig(400, "Erro ao excluir o perfil tela" + InnerExceptionMessage.InnerExceptionError(e), false);
            }
            return response.GetResponse();
        }
    }
}