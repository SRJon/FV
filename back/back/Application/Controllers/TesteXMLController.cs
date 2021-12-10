using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using back.domain.DTO.TGFParceiroDTO;
using back.domain.DTO.TSICidadeDTO;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace back.Application.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TesteXMLController : ControllerBase
    {
        [AllowAnonymous]
        [HttpPost]
        [Route("teste")]
        public IActionResult Teste(TGFPARDTOCreate clienteCreate)
        {
            return Ok(clienteCreate.ProductEntityToJson("Parceiro"));
        }
    }

}