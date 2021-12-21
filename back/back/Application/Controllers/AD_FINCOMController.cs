using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using AutoMapper;
using back.data.entities.VIEW_AD_VGFRPV;
using back.data.http;
using back.domain.DTO.ViewAD_FINCOMDTO;
using back.domain.entities;
using back.domain.Repositories;
using back.infra.Services.Authentication;
using back.MappingConfig;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Net.Http.Headers;

namespace back.Application.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AD_FINCOMController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly IAD_FINCOMRepository _AD_FINCOMRepository;
        private readonly IUserRepository _UserRepository;

        public AD_FINCOMController(IAD_FINCOMRepository aD_FINCOMRepository, IUserRepository userRepository)
        {
            _mapper = MapperConfig.MapperConfiguration().CreateMapper();
            _AD_FINCOMRepository = aD_FINCOMRepository;
            _UserRepository = userRepository;
        }

        [HttpGet]
        [Authorize]
        public async Task<ActionResult<IResponse<List<AD_FINCOMDTO>>>> GetAllAsync([FromQuery] AD_VGFRPVGetAllEntity payload)
        {
            string token = "";
            var authorization = Request.Headers[HeaderNames.Authorization];
            if (AuthenticationHeaderValue.TryParse(authorization, out var headerValue))
            {
                token = headerValue.Parameter;
            }
            var id = TokenService.getIdByToken(token);
            var user = await _UserRepository.GetById(id);


            var response = new Response<List<AD_FINCOMDTO>>();
            try
            {
                if (user != null)
                {
                    var result = await _AD_FINCOMRepository.GetAllPaginateAsync(payload.page, payload.limit, (int)user.VendedorUCod);
                    response.SetConfig(200);
                    response.Data = result.Data;
                    response.setHttpAtr(result);
                }
                else
                {
                    response.SetConfig(400, "Não há vendedor associado ao usuário - AD_FINCOM", false);
                }
            }
            catch (System.Exception e)
            {
                response.SetConfig(404, "Erro ao buscar as Comissões", false);
            }
            return response.GetResponse();
        }

        [HttpGet]
        [Authorize]
        [Route("GetByIdParc")]

        public async Task<ActionResult<IResponse<AD_FINCOMDTO>>> getById(int nuFim)
        {
            var response = new Response<AD_FINCOMDTO>();

            try
            {
                var result = await this._AD_FINCOMRepository.GetById(nuFim);
                if (result != null)
                {
                    response.SetConfig(200);
                    response.Data = result;
                }
                else
                {
                    response.SetConfig(404, "Comissao não encontrada", false);
                }
            }
            catch (System.Exception)
            {
                response.SetConfig(400, "Erro ao buscar a Comissão", false);
            }
            return response.GetResponse();

        }
    }
}