using System.Threading.Tasks;
using AutoMapper;
using back.data.http;
using back.domain.DTO.TSIEnderecoDTO;
using back.domain.entities;
using back.domain.Repositories;
using back.infra.Data.Utils;
using back.MappingConfig;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace back.Application.Controllers
{
    /// <summary>
    /// Controller da TSIEND, entidade sankhya de endereço 1
    /// </summary>
    [Route("api/[controller]")]
    /// <summary>
    /// Controller da TSIEND, entidade sankhya de endereço 2 
    /// </summary> 
    public class TSIENDController : ControllerBase
    {
        /// <summary>
        /// Controller da TSIEND, entidade sankhya de endereço 3
        /// </summary>
        private readonly ITSIENDRepository _ITSIENDRepository;
        private readonly IMapper _mapper;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="iTSIENDRepository"></param>
        /// <param name="mapper"></param>
        public TSIENDController(ITSIENDRepository iTSIENDRepository, IMapper mapper)
        {
            _ITSIENDRepository = iTSIENDRepository;
            _mapper = MapperConfig.MapperConfiguration().CreateMapper();
        }

        /// <summary>
        /// Busca de endereço por ID
        /// </summary>
        /// <param name="id">ID do endereço</param>
        /// <returns>Endereço sankhya</returns>

        [HttpGet("{id}")]
        [Authorize]
        public async Task<ActionResult<IResponse<TSIENDDTO>>> GetById(int id)
        {
            var response = new Response<TSIENDDTO>();
            try
            {
                TSIENDDTO result = await this._ITSIENDRepository.GetById(id);
                if (result != null)
                {
                    response.SetConfig(200);
                    response.Data = result;
                }
                else
                {
                    response.SetConfig(404, "Endereço não encontrado", false);
                }
            }
            catch (System.Exception e)
            {
                response.SetConfig(400, "Erro ao buscar Endereço " + e.Message, false);
            }
            return response.GetResponse();
        }
        /// <summary>
        /// Busca de endereço no Sankhya via Nome do endereço
        /// </summary>
        /// <param name="nomeEnd">Nome do endereço, ex. RUA 3</param>
        /// <returns>TSIEND</returns>
        [HttpGet]
        [Authorize]
        [Route("GetByNomeEnd")]
        public async Task<ActionResult<IResponse<TSIENDDTO>>> GetByNomeEnd(string nomeEnd)
        {
            var response = new Response<TSIENDDTO>();
            try
            {
                TSIENDDTO result = await this._ITSIENDRepository.GetByNome(nomeEnd);
                if (result != null)
                {
                    response.SetConfig(200);
                    response.Data = result;
                }
                else
                {
                    response.SetConfig(404, "Endereço não encontrado", false);
                }
            }
            catch (System.Exception e)
            {
                response.SetConfig(400, "Erro ao buscar endereço " + e.Message, false);
            }
            return response.GetResponse();
        }

        /// <summary>
        /// Criador de TSIEND utilizando a API do Sankhya para tal.
        /// </summary>
        /// <param name="tsiend">Endereço a ser criado</param>
        /// <returns>BOOl</returns>
        [HttpPost]
        [Authorize]
        [Route("Create")]
        public async Task<ActionResult<IResponse<bool>>> create(TSIENDDTOCreate tsiend)
        {

            var response = new Response<bool>();
            try
            {
                var result = await this._ITSIENDRepository.Create(tsiend);
                if (result)
                {
                    response.SetConfig(200);
                    response.Data = result;
                }
                else
                {
                    response.SetConfig(404, "Endereço não criado", false);
                }
            }
            catch (System.Exception e)
            {
                response.SetConfig(400, "Erro ao criar o endereço " + InnerExceptionMessage.InnerExceptionError(e), false);
            }
            return response.GetResponse();
        }
    }
}