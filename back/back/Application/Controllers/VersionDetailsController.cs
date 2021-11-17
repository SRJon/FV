using System.Collections.Generic;
using System.Threading.Tasks;
using back.data.entities.VersionDetails;
using back.data.entities.Enterprise;
using back.data.http;
using back.domain.DTO.VersionDetails;
using back.domain.Repositories;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace back.Application.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class VersionDetailsController : ControllerBase
    {
        private IVersionDetailsRepository _VersionDetailsRepository;


        public VersionDetailsController(IVersionDetailsRepository VersionDetailsRepository)
        {

            _VersionDetailsRepository = VersionDetailsRepository;
        }

        [HttpGet]
        [Authorize]
        public async Task<ActionResult<Response<List<VersionDetails>>>> GetAllAsync([FromQuery] VersionDetailsGetAllEntity payload)

        {
            Response<List<VersionDetailsDTO>> result = null;
            try
            {
                result = await _VersionDetailsRepository.GetAllPaginateAsync(payload.page, payload.limit);
            }
            catch (System.Exception e)
            {
                return BadRequest(new Response<string>
                {
                    Message = "Erro ao buscar os VersionDetailss",
                    Data = e.Message,
                    Success = false,
                    StatusCode = 400

                });

            }
            return Ok(result);
        }

        [HttpGet("{id}")]
        [Authorize]
        public async Task<ActionResult<Response<VersionDetails>>> getById(int id)
        {
            Response<VersionDetailsDTO> response = null;

            try
            {
                VersionDetailsDTO result = await this._VersionDetailsRepository.GetById(id);
                if (result != null)
                {
                    response = new Response<VersionDetailsDTO>
                    {
                        Message = "VersionDetails encontrado com sucesso",
                        Data = result,
                        Success = true,
                        StatusCode = 200
                    };
                }
                else
                {
                    response = new Response<VersionDetailsDTO>
                    {
                        Message = "VersionDetails não encontrado",
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
                    Message = "Erro ao buscar o VersionDetails",
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
        public async Task<ActionResult<Response<bool>>> create(VersionDetails VersionDetails)
        {
            Response<bool> response = null;

            try
            {
                var result = await this._VersionDetailsRepository.Create(VersionDetails);
                if (result)
                {
                    response = new Response<bool>
                    {
                        Message = "VersionDetails criada com sucesso",
                        Data = result,
                        Success = true,
                        StatusCode = 200
                    };
                }
                else
                {
                    response = new Response<bool>
                    {
                        Message = "VersionDetails não criado",
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
                    Message = "Erro ao criar o VersionDetails",
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
        public async Task<ActionResult<Response<bool>>> update(VersionDetails VersionDetails)
        {
            Response<bool> response = null;
            try
            {
                var result = await this._VersionDetailsRepository.Update(VersionDetails);
                if (result)
                {
                    response = new Response<bool>
                    {
                        Message = "VersionDetails atualizado com sucesso",
                        Data = result,
                        Success = true,
                        StatusCode = 200
                    };
                }
                else
                {
                    response = new Response<bool>
                    {
                        Message = "VersionDetails não atualizado",
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
                    Message = "Erro ao atualizar o VersionDetails",
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
                var result = await this._VersionDetailsRepository.Delete(id);
                if (result)
                {
                    response = new Response<bool>
                    {
                        Message = "VersionDetails excluido com sucesso",
                        Data = result,
                        Success = true,
                        StatusCode = 200
                    };
                }
                else
                {
                    response = new Response<bool>
                    {
                        Message = "VersionDetails não excluido",
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
                    Message = "Erro ao excluir o VersionDetails",
                    Data = e.Message,
                    Success = false,
                    StatusCode = 400
                });
            }
        }


    }

}
