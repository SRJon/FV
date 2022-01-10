using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using back.data.http;
using back.domain.DTO.AD_PRODUTO_PV;
using back.domain.entities;
using back.domain.Repositories;
using back.MappingConfig;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace back.Application.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AD_PRODUTO_PVController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly IAD_PRODUTO_PVRepository _AD_PRODUTO_PVRepository;
        private readonly IUserRepository _UserRepository;

        public AD_PRODUTO_PVController(IAD_PRODUTO_PVRepository AD_PRODUTO_PV_Repository)
        {
            _mapper = MapperConfig.MapperConfiguration().CreateMapper();
            _AD_PRODUTO_PVRepository = AD_PRODUTO_PV_Repository;
        }

        [HttpGet]
        [AllowAnonymous]
        [Route("GetByNunota")]

        public async Task<ActionResult<IResponse<AD_PRODUTO_PVDTO>>> getByNunota(int Nunota) {
            
            var response = new Response<AD_PRODUTO_PVDTO>();

            try
            {
                AD_PRODUTO_PVDTO result = await this._AD_PRODUTO_PVRepository.GetByNunota(Nunota);

                if (result != null)
                {
                    response.SetConfig(200);
                    response.Data = result;
                }
                else
                {
                    response.SetConfig(404, "Pedido não encontrado", false);
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