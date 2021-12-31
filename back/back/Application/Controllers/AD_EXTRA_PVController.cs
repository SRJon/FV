using System.Threading.Tasks;
using AutoMapper;
using back.data.http;
using back.domain.DTO.AD_EXTRA_PVDTO;
using back.domain.entities;
using back.domain.Repositories;
using back.MappingConfig;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace back.Application.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AD_EXTRA_PVController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly IAD_EXTRA_PVRepository _AD_EXTRA_PVRepository;   
        private readonly IUserRepository _UserRepository;

        public AD_EXTRA_PVController(IAD_EXTRA_PVRepository AD_EXTRA_PV_Repository){
            _mapper = MapperConfig.MapperConfiguration().CreateMapper();
            _AD_EXTRA_PVRepository = AD_EXTRA_PV_Repository;
        }

        [HttpGet]
        [AllowAnonymous]
        [Route("GetByNunota")]

        public async Task<ActionResult<IResponse<AD_EXTRA_PVDTO>>> getByNunota(int Nunota){
            
            var response = new Response<AD_EXTRA_PVDTO>();

            try
            {
                var result = await this._AD_EXTRA_PVRepository.GetByNunota(Nunota);

                if (result != null)
                {
                    response.SetConfig(200);
                    response.Data = result;
                }
                else
                {
                    response.SetConfig(404, "Pedido não encontrado.", false);
                }
            }
            catch (System.Exception)
            {
                response.SetConfig(400, "Erro ao buscar pedido", false);
            }
            return response.GetResponse();
        }
    }
}