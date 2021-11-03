using System.ComponentModel.DataAnnotations;
using AutoMapper;
using back.data.entities.Login;
using back.data.entities.User;
using back.domain.Repositories;
using back.DTO.Authentication;
using back.infra.Services.Authentication;
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
            var mapperConfig = new MapperConfiguration(mc =>
      {
          //    mc.AddProfile(new MappingProfile());
      });

            _mapper = new Mapper(mapperConfig);
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



        [HttpGet("/logout")]
        [Authorize]
        public ActionResult teste()
        {

            return Ok();
        }

    }
}