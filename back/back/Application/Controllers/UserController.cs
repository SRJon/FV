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
        public async Task<ActionResult<Response<List<Usuario>>>> GetAll(int page = 1, int limit = 10)
        {


            var response = await _usuarioRepository.GetAllAsync(page, limit);

            var result = new HttpAdapter<Response<List<Usuario>>>(response.StatusCode, response);
            return result.GetResponse();
        }


        [HttpGet("/{id}")]
        public ActionResult<Response<Usuario>> GetById(int id)
        {
            var response = _usuarioRepository.GetByIdAsync(id);

            var result = new HttpAdapter<Response<Usuario>>(response.StatusCode, response);

            return result.GetResponse();
        }
    }
}