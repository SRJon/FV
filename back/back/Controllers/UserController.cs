using System;
using System.Collections.Generic;
using back.data.entities;
using back.domain.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace back.Controllers
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

        [HttpGet]
        public List<Usuario> GetAll()
        {
            return _usuarioRepository.GetAll();
        }
    }
}