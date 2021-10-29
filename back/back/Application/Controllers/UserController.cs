using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using back.data.entities.User;
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
        public async Task<List<Usuario>> GetAll(int page = 1, int limit = 10)
        {


            return await _usuarioRepository.GetAllAsync(page, limit);
        }
    }
}