using System.Threading.Tasks;
using AutoMapper;
using back.data.http;
using back.domain.DTO.TSIEnderecoDTO;
using back.domain.entities;
using back.domain.Repositories;
using back.MappingConfig;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace back.Application.Controllers
{
    public class TSIENDController : ControllerBase
    {
        private readonly ITSIENDRepository _ITSIENDRepository;
        private readonly IMapper _mapper;

        public TSIENDController(ITSIENDRepository iTSIENDRepository, IMapper mapper)
        {
            _ITSIENDRepository = iTSIENDRepository;
            _mapper = MapperConfig.MapperConfiguration().CreateMapper();
        }

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
                    response.SetConfig(404, "Parceiro não encontrado", false);
                }
            }
            catch (System.Exception e)
            {
                response.SetConfig(400, "Erro ao buscar parceiro " + e.Message, false);
            }
            return response.GetResponse();
        }
    }
}