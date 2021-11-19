using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using back.data.entities.ProfileScreen;
using back.data.http;
using back.domain.DTO.ProfileScreenDTO;
using back.domain.entities;
using back.domain.Repositories;
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
        public async Task<ActionResult<Response<bool>>> create(PerfilTelaDTOCreate perfilTela)
        {
            Response<bool> response = null;
            try
            {
                var result = await this._perfilTelaRepository.Create(perfilTela);
                if (result)
                {
                    response = new Response<bool>
                    {
                        Message = "Perfil tela criada com sucesso",
                        Data = result,
                        Success = true,
                        StatusCode = 200
                    };
                }
                else
                {
                    response = new Response<bool>
                    {
                        Message = "Perfil tela não criada",
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
                    Message = "Erro ao criar a Perfil tela",
                    Data = e.Message,
                    Success = false,
                    StatusCode = 400
                });
            }
            return Ok(response);
        }

        [HttpGet("{id}")]
        [AllowAnonymous]
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
            catch (System.Exception)
            {
                response.SetConfig(400, "Erro ao buscar a perfil tela", false);
            }

            return response.GetResponse();
        }

        [HttpGet]
        [AllowAnonymous]
        public async Task<ActionResult<IResponse<List<PerfilTelaDTO>>>> GetAllAsync([FromQuery] ProfileScreenGetAllEntity payload)
        {
            var response = new Response<List<PerfilTelaDTO>>();
            try
            {
                var result = await _perfilTelaRepository.GetAllPaginateAsync(payload.page, payload.limit);
                response.SetConfig(200);
                response.Data = result.Data;
            }
            catch (System.Exception)
            {
                response.SetConfig(404, "Erro ao buscar as perfis tela", false);
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
            catch (System.Exception)
            {
                response.SetConfig(400, "Erro ao atualizar o Perfil tela", false);
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
            catch (System.Exception)
            {
                response.SetConfig(400, "Erro ao excluir o perfil tela", false);
            }
            return response.GetResponse();
        }
    }
}