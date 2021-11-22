using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using back.data.entities.Profile;
using back.data.http;
using back.domain.DTO.ProfileDTO;
using back.domain.entities;
using back.domain.Repositories;
using back.MappingConfig;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace back.Application.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PerfilController : ControllerBase
    {
        private readonly IMapper _mapper;
        private IPerfilRepository _perfilRepository;

        public PerfilController(IPerfilRepository perfilRepository)
        {
            _mapper = MapperConfig.MapperConfiguration().CreateMapper();
            _perfilRepository = perfilRepository;
        }

        [HttpPost]
        [Authorize]
        [Route("Create")]
        public async Task<ActionResult<IResponse<bool>>> create(PerfilDTOCreate perfil)
        {
            var response = new Response<bool>();
            try
            {
                var result = await this._perfilRepository.Create(perfil);
                if (result)
                {
                    response.SetConfig(200);
                    response.Data = result;

                }
                else
                {
                    response.SetConfig(404, "Pefil não criado", false);
                }
            }
            catch (System.Exception)
            {
                response.SetConfig(400, "Erro ao criar a perfil", false);
            }
            return response.GetResponse();
        }

        [HttpGet("{id}")]
        [Authorize]
        public async Task<ActionResult<IResponse<PerfilDTO>>> getById(int id)
        {
            var response = new Response<PerfilDTO>();
            try
            {
                var result = await this._perfilRepository.GetById(id);
                if (result != null)
                {
                    response.SetConfig(200);
                    response.Data = result;
                }
                else
                {
                    response.SetConfig(404, "Perfil não encontrado", false);
                }
            }
            catch (System.Exception)
            {
                response.SetConfig(400, "Erro ao buscar a perfil", false);
            }
            return response.GetResponse();
        }

        [HttpGet]
        [Authorize]
        public async Task<ActionResult<IResponse<List<PerfilDTO>>>> GetAllAsync([FromQuery] ProfileGetAllEntity payload)
        {
            var response = new Response<List<PerfilDTO>>();
            try
            {
                var result = await _perfilRepository.GetAllPaginateAsync(payload.page, payload.limit);
                response.SetConfig(200);
                response.Data = result.Data;
                response.setHttpAtr(result);
            }
            catch (System.Exception)
            {
                response.SetConfig(404, "Erro ao buscar as perfis", false);
            }
            return response.GetResponse();
        }

        [HttpPost]
        [Route("Update")]
        [Authorize]
        public async Task<ActionResult<IResponse<bool>>> update(PerfilDTOUpdateDTO perfil)
        {
            var response = new Response<bool>();
            try
            {
                var result = await this._perfilRepository.Update(perfil);
                if (result)
                {
                    response.SetConfig(200);
                    response.Data = result;
                }
                else
                {
                    response.SetConfig(404, "Perfil não atualizado", false);
                }
            }
            catch (System.Exception)
            {
                response.SetConfig(400, "Erro ao atualizar o Perfil", false);
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
                var result = await this._perfilRepository.Delete(id);
                if (result)
                {
                    response.SetConfig(200);
                    response.Data = result;
                }
                else
                {
                    response.SetConfig(404, "Perfil não excluido", false);
                }
            }
            catch (System.Exception)
            {
                response.SetConfig(400, "Erro ao excluir o perfil", false);
            }
            return response.GetResponse();
        }

    }
}