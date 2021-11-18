using System.Collections.Generic;
using System.Threading.Tasks;
using back.data.entities.Informativo;
using back.data.entities.Enterprise;
using back.data.http;
using back.domain.DTO.Informativo;
using back.domain.Repositories;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace back.Application.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class InformativoController : ControllerBase
    {
        private IInformativoRepository _InformativoRepository;


        public InformativoController(IInformativoRepository InformativoRepository)
        {

            _InformativoRepository = InformativoRepository;
        }

        [HttpGet]
        [Authorize]
        public async Task<ActionResult<Response<List<Informativo>>>> GetAllAsync([FromQuery] InformativoGetAllEntity payload)

        {
            Response<List<InformativoDTO>> result = null;
            try
            {
                result = await _InformativoRepository.GetAllPaginateAsync(payload.page, payload.limit);
            }
            catch (System.Exception e)
            {
                return BadRequest(new Response<string>
                {
                    Message = "Erro ao buscar os Informativos",
                    Data = e.Message,
                    Success = false,
                    StatusCode = 400

                });

            }
            return Ok(result);
        }

        [HttpGet("{id}")]
        [Authorize]
        public async Task<ActionResult<Response<Informativo>>> getById(int id)
        {
            Response<InformativoDTO> response = null;

            try
            {
                InformativoDTO result = await this._InformativoRepository.GetById(id);
                if (result != null)
                {
                    response = new Response<InformativoDTO>
                    {
                        Message = "Informativo encontrado com sucesso",
                        Data = result,
                        Success = true,
                        StatusCode = 200
                    };
                }
                else
                {
                    response = new Response<InformativoDTO>
                    {
                        Message = "Informativo não encontrado",
                        Data = null,
                        Success = false,
                        StatusCode = 404
                    };
                }
            }
            catch (System.Exception e)
            {

                return BadRequest(new Response<string>
                {
                    Message = "Erro ao buscar o Informativo",
                    Data = e.Message,
                    Success = false,
                    StatusCode = 400
                });


            }


            return Ok(response);
        }

        [HttpPost]
        [Authorize]
        [Route("Create")]
        public async Task<ActionResult<Response<bool>>> create(Informativo Informativo)
        {
            Response<bool> response = null;

            try
            {
                var result = await this._InformativoRepository.Create(Informativo);
                if (result)
                {
                    response = new Response<bool>
                    {
                        Message = "Informativo criada com sucesso",
                        Data = result,
                        Success = true,
                        StatusCode = 200
                    };
                }
                else
                {
                    response = new Response<bool>
                    {
                        Message = "Informativo não criado",
                        Data = result,
                        Success = false,
                        StatusCode = 404
                    };
                }
            }
            catch (System.Exception e)
            {

                return BadRequest(new Response<string>
                {
                    Message = "Erro ao criar o Informativo",
                    Data = e.Message,
                    Success = false,
                    StatusCode = 400
                });
            }


            return Ok(response);

        }

        [HttpPost()]
        [Route("Update")]
        [Authorize]
        public async Task<ActionResult<Response<bool>>> update(Informativo Informativo)
        {
            Response<bool> response = null;
            try
            {
                var result = await this._InformativoRepository.Update(Informativo);
                if (result)
                {
                    response = new Response<bool>
                    {
                        Message = "Informativo atualizado com sucesso",
                        Data = result,
                        Success = true,
                        StatusCode = 200
                    };
                }
                else
                {
                    response = new Response<bool>
                    {
                        Message = "Informativo não atualizado",
                        Data = result,
                        Success = false,
                        StatusCode = 404
                    };
                }
                return response;
            }
            catch (System.Exception e)
            {
                return BadRequest(new Response<string>
                {
                    Message = "Erro ao atualizar o Informativo",
                    Data = e.Message,
                    Success = false,
                    StatusCode = 400
                });
            }
        }
        [HttpPost]
        [Route("Delete")]
        [Authorize]
        public async Task<ActionResult<Response<bool>>> delete(int id)
        {
            Response<bool> response = null;
            try
            {
                var result = await this._InformativoRepository.Delete(id);
                if (result)
                {
                    response = new Response<bool>
                    {
                        Message = "Informativo excluido com sucesso",
                        Data = result,
                        Success = true,
                        StatusCode = 200
                    };
                }
                else
                {
                    response = new Response<bool>
                    {
                        Message = "Informativo não excluido",
                        Data = result,
                        Success = false,
                        StatusCode = 404
                    };
                }
                return response;
            }
            catch (System.Exception e)
            {
                return BadRequest(new Response<string>
                {
                    Message = "Erro ao excluir o Informativo",
                    Data = e.Message,
                    Success = false,
                    StatusCode = 400
                });
            }
        }


    }

}
