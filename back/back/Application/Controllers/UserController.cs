using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using back.data.entities.User;
using back.data.http;
using back.domain.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace back.Application.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UsuarioController : ControllerBase
    {
        protected readonly IUserRepository _usuarioRepository;


        public UsuarioController(IUserRepository usuarioRepository)
        {
            _usuarioRepository = usuarioRepository;
        }

        [HttpGet("/")]
        public async Task<IActionResult> GetAll(int page = 1, int limit = 10)
        {


            var response = await _usuarioRepository.GetAllAsync(page, limit);


            if (response.Success)
            {
                return Ok(response);
            }
            else
            {
                return BadRequest(response);
            }
        }


        [HttpGet("/{id}")]
        public ActionResult<Usuario> GetById(int id)
        {
            var response = _usuarioRepository.GetByIdAsync(id);

            var result = new HttpAdapter<Usuario>(response.StatusCode, response);

            return result.GetResponse();
        }
    }
}