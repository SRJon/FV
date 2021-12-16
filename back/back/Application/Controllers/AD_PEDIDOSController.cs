using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using back.data.http;
using back.domain.DTO.AD_PEDIDOSDTO;
using back.domain.entities;
using back.domain.Repositories;
using back.MappingConfig;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace back.Application.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AD_PEDIDOSController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly IAD_PEDIDOSRepository _AD_PEDIDOS_Repository;
        private readonly IUserRepository _UserRepository;
        public AD_PEDIDOSController(IAD_PEDIDOSRepository AD_PEDIDSORepository)
        {
            _mapper = MapperConfig.MapperConfiguration().CreateMapper();
            _AD_PEDIDOS_Repository = AD_PEDIDSORepository;
        }

        [HttpGet]
        [AllowAnonymous]
        public async Task<ActionResult<IResponse<List<AD_PEDIDOSDTO>>>> getAll(int page = 1, int limit = 10){

            var response = new Response<List<AD_PEDIDOSDTO>>();

            try
            {
                var result = await _AD_PEDIDOS_Repository.GetAllPaginateAsync(page, limit);
                response.SetConfig(200);
                response.Data = result.Data;
            }
            catch (System.Exception)
            {
                response.SetConfig(400, "Erro ao buscar as Condições de pagamento", false);
            }
            return response.GetResponse();
        }

        [HttpGet]
        [AllowAnonymous]
        [Route("GetByNunota")]

        public async Task<ActionResult<IResponse<AD_PEDIDOSDTO>>> getByNunota(int Nunota)
        {
            var response = new Response<AD_PEDIDOSDTO>();

            try
            {
                var result = await this._AD_PEDIDOS_Repository.GetByNunota(Nunota);

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
