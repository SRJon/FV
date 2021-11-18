using System.Collections.Generic;
using System.Threading.Tasks;
using back.data.entities.VersaoProjetos;
using back.data.entities.Enterprise;
using back.data.http;
using back.domain.DTO.VersaoProjetos;
using back.domain.Repositories;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace back.Application.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class VersaoProjetosController : ControllerBase
    {
        private IVersaoProjetosRepository _VersaoProjetosRepository;


        public VersaoProjetosController(IVersaoProjetosRepository VersaoProjetosRepository)
        {

            _VersaoProjetosRepository = VersaoProjetosRepository;
        }

        [HttpGet]
        [Authorize]
        public async Task<ActionResult<Response<List<VersaoProjetos>>>> GetAllAsync([FromQuery] VersaoProjetosGetAllEntity payload)

        {
            Response<List<VersaoProjetosDTO>> result = null;
            try
            {
                result = await _VersaoProjetosRepository.GetAllPaginateAsync(payload.page, payload.limit);
            }
            catch (System.Exception e)
            {
                return BadRequest(new Response<string>
                {
                    Message = "Erro ao buscar os VersaoProjetoss",
                    Data = e.Message,
                    Success = false,
                    StatusCode = 400

                });

            }
            return Ok(result);
        }

        [HttpGet("{id}")]
        [Authorize]
        public async Task<ActionResult<Response<VersaoProjetos>>> getById(int id)
        {
            Response<VersaoProjetosDTO> response = null;

            try
            {
                VersaoProjetosDTO result = await this._VersaoProjetosRepository.GetById(id);
                if (result != null)
                {
                    response = new Response<VersaoProjetosDTO>
                    {
                        Message = "VersaoProjetos encontrado com sucesso",
                        Data = result,
                        Success = true,
                        StatusCode = 200
                    };
                }
                else
                {
                    response = new Response<VersaoProjetosDTO>
                    {
                        Message = "VersaoProjetos não encontrado",
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
                    Message = "Erro ao buscar o VersaoProjetos",
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
        public async Task<ActionResult<Response<bool>>> create(VersaoProjetos VersaoProjetos)
        {
            Response<bool> response = null;

            try
            {
                var result = await this._VersaoProjetosRepository.Create(VersaoProjetos);
                if (result)
                {
                    response = new Response<bool>
                    {
                        Message = "VersaoProjetos criada com sucesso",
                        Data = result,
                        Success = true,
                        StatusCode = 200
                    };
                }
                else
                {
                    response = new Response<bool>
                    {
                        Message = "VersaoProjetos não criado",
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
                    Message = "Erro ao criar o VersaoProjetos",
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
        public async Task<ActionResult<Response<bool>>> update(VersaoProjetos VersaoProjetos)
        {
            Response<bool> response = null;
            try
            {
                var result = await this._VersaoProjetosRepository.Update(VersaoProjetos);
                if (result)
                {
                    response = new Response<bool>
                    {
                        Message = "VersaoProjetos atualizado com sucesso",
                        Data = result,
                        Success = true,
                        StatusCode = 200
                    };
                }
                else
                {
                    response = new Response<bool>
                    {
                        Message = "VersaoProjetos não atualizado",
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
                    Message = "Erro ao atualizar o VersaoProjetos",
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
                var result = await this._VersaoProjetosRepository.Delete(id);
                if (result)
                {
                    response = new Response<bool>
                    {
                        Message = "VersaoProjetos excluido com sucesso",
                        Data = result,
                        Success = true,
                        StatusCode = 200
                    };
                }
                else
                {
                    response = new Response<bool>
                    {
                        Message = "VersaoProjetos não excluido",
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
                    Message = "Erro ao excluir o VersaoProjetos",
                    Data = e.Message,
                    Success = false,
                    StatusCode = 400
                });
            }
        }


    }

}
