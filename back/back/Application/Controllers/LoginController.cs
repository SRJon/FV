using System.ComponentModel.DataAnnotations;
using AutoMapper;
using back.data.entities.Login;
using back.data.entities.User;
using back.domain.entities;
using back.domain.Repositories;
using back.DTO.Authentication;
using back.infra.Services.Authentication;
using back.MappingConfig;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace back.Application.Controllers
{

    [ApiController]
    [Route("[controller]")]
    public class LoginController : ControllerBase
    {

        private readonly IMapper _mapper;
        private readonly IUserRepository _userRepository;
        public LoginController(IUserRepository userRepository)
        {
            this._mapper = MapperConfig.MapperConfiguration().CreateMapper();

            _userRepository = userRepository;
        }

        [HttpPost("/login")]
        [AllowAnonymous]
        public IActionResult Login([FromBody] LoginEntity user)
        {
            var UserId = _userRepository.UserValidation(user);

            if (UserId > 0)
            {
                Usuario userCredentials = _userRepository.GetByIdAsync(int.Parse(UserId.ToString()));
                var token = TokenService.GenerateToken(userCredentials.ToDto());
                return Ok(new { token });
            }
            return BadRequest("Invalid login");
        }



        [HttpGet("/refreshToken")]
        [AllowAnonymous]
        public ActionResult<TokenResponse> RefreshToken([FromQuery] string token)
        {
            var tokenString = TokenService.RefreshToken(token);


            return Ok(new TokenResponse { token = tokenString });
        }

        [HttpPost("/mapping")]
        public testeDTO testeMapping([FromBody] Teste teste)
        {

            var t = _mapper.Map<testeDTO>(teste);
            var s = _mapper.Map<Teste>(t);
            return _mapper.Map<testeDTO>(s);
        }

    }
}