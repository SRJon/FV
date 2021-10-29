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
        protected readonly IUsuarioRepository _usuarioRepository;


        public UsuarioController(IUsuarioRepository usuarioRepository)
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