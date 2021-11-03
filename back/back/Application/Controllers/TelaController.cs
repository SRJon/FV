using System.Threading.Tasks;
using back.data.entities.Screen;
using back.domain.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace back.Application.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TelaController : ControllerBase
    {

        private ITelaRepository _telaRepository;

        public TelaController(ITelaRepository telaRepository)
        {
            _telaRepository = telaRepository;
        }
        [HttpGet]
        public async Task<IActionResult> GetAllAsync([FromQuery] ScreenGetAllEntity payload)

        {
            var result = await _telaRepository.GetAllPaginateAsync(payload.page, payload.limit);
            return Ok(result);
        }
    }
}