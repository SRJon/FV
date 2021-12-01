using System.Threading.Tasks;
using AutoMapper;
using back.data.entities.Login;
using back.data.entities.User;
using back.data.http;
using back.domain.DTO.Login;
using back.domain.entities;
using back.domain.Repositories;
using back.DTO.Authentication;
using back.infra.Data.Utils;
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


        [HttpPost("/getUserByToken")]
        [Authorize]
        public async Task<ActionResult<IResponse<UserAuthenticateDto>>> getUserByTokenAsync([FromBody] TokenEntity token)
        {
            var response = new Response<UserAuthenticateDto>();
            try
            {
                var id = TokenService.getIdByToken(token.token);
                var user = await _userRepository.GetById(id);
                var UserMapped = _mapper.Map<UserAuthenticateDto>(user);
                if (user != null)
                {
                    // response.Data = user.ToDto();
                    UserMapped.token = token.token;
                    response.SetConfig(200);
                    response.Data = UserMapped;
                }
                else
                {
                    response.SetConfig(404, "Usuário Não encontrado com sucesso", false);
                }


            }
            catch (System.Exception e)
            {

                response.SetConfig(404, "Usuário Não encontrado com sucesso " + InnerExceptionMessage.InnerExceptionError(e), false);
            }
            return response.GetResponse();
        }

    }
}