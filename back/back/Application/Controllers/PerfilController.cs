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
                    response.Data = result;
                }
            }
            catch (System.Exception)
            {
                response.SetConfig(400, "Erro ao criar a perfil", false);
            }
            return response.GetResponse();
        }

        [HttpGet("{id}")]
        [AllowAnonymous]
        public async Task<ActionResult<IResponse<Perfil>>> getById(int id)
        {
            var response = new Response<Perfil>();

            try
            {
                var result = await this._perfilRepository.GetById(id);
                if (result != null)
                {
                    response.SetConfig(200);
                    response.Data = _mapper.Map<Perfil>(result);
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
        [AllowAnonymous]
        public async Task<ActionResult<IResponse<List<Perfil>>>> GetAllAsync([FromQuery] ProfileGetAllEntity payload)
        {
            var response = new Response<List<Perfil>>();
            try
            {
                //TODO vericar forma sucinta de fazer isso.
                var result = await _perfilRepository.GetAllPaginateAsync(payload.page, payload.limit);
                response.SetConfig(200);
                List<Perfil> resultado = new List<Perfil>();
                foreach (PerfilDTO item in result.Data)
                {
                    resultado.Add(_mapper.Map<Perfil>(item));
                }
                response.Data = resultado;
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