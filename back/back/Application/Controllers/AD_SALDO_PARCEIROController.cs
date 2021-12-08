using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using back.data.http;
using back.domain.DTO.ViewAD_SALDO_PARCEIRODTO;
using back.domain.entities;
using back.domain.Repositories;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace back.Application.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AD_SALDO_PARCEIROController : ControllerBase
    {
        private readonly IAD_SALDO_PARCEIRORepository _IAD_SALDO_PARCEIRORepository;

        public AD_SALDO_PARCEIROController(IAD_SALDO_PARCEIRORepository IAD_SALDO_PARCEIRORepository)
        {
            _IAD_SALDO_PARCEIRORepository = IAD_SALDO_PARCEIRORepository;
        }

        [HttpGet("{id}")]
        [AllowAnonymous]
        public async Task<ActionResult<IResponse<AD_SALDO_PARCEIRODTO>>> GetById(int id)
        {
            var response = new Response<AD_SALDO_PARCEIRODTO>();
            try
            {
                AD_SALDO_PARCEIRODTO result = await this._IAD_SALDO_PARCEIRORepository.GetById(id);
                if (result != null)
                {
                    response.SetConfig(200);
                    response.Data = result;
                }
                else
                {
                    response.SetConfig(404, "Saldo não encontrado", false);
                }
            }
            catch (System.Exception e)
            {
                response.SetConfig(400, "Erro ao buscar saldo " + e.Message, false);
            }
            return response.GetResponse();
        }

        private class AuthorizeAttribute : Attribute
        {
        }
    }
}