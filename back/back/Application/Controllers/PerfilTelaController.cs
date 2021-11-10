using System.Threading.Tasks;
using AutoMapper;
using back.data.entities.ProfileScreen;
using back.data.http;
using back.domain.DTO.ProfileScreenDTO;
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
        public async Task<ActionResult<Response<bool>>> create(PerfilTela perfilTela)
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
        [Authorize]
        public async Task<ActionResult<Response<PerfilTela>>> getById(int id)
        {
            Response<PerfilTelaDTO> response = null;
            try
            {
                PerfilTelaDTO result = await this._perfilTelaRepository.GetById(id);
                if (result != null)
                {
                    response = new Response<PerfilTelaDTO>
                    {
                        Message = "Perfil Tela encontrada com sucesso",
                        Data = result,
                        Success = true,
                        StatusCode = 200
                    };
                }
                else
                {
                    response = new Response<PerfilTelaDTO>
                    {
                        Message = "Perfil tela não encontrada",
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
                    Message = "Erro ao buscar o Perfil Tela",
                    Data = e.Message,
                    Success = false,
                    StatusCode = 400
                });
            }

            return Ok(response);
        }

    }
}