using System.Collections.Generic;
using System.Threading.Tasks;
using back.data.entities.UserCustomizations;
using back.data.entities.Enterprise;
using back.data.http;
using back.domain.DTO.UserCustomizations;
using back.domain.Repositories;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace back.Application.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserCustomizationsController : ControllerBase
    {
        private IUserCustomizationsRepository _UserCustomizationsRepository;


        public UserCustomizationsController(IUserCustomizationsRepository UserCustomizationsRepository)
        {

            _UserCustomizationsRepository = UserCustomizationsRepository;
        }

        [HttpGet]
        [Authorize]
        public async Task<ActionResult<Response<List<UserCustomizations>>>> GetAllAsync([FromQuery] UserCustomizationsGetAllEntity payload)

        {
            Response<List<UserCustomizationsDTO>> result = null;
            try
            {
                result = await _UserCustomizationsRepository.GetAllPaginateAsync(payload.page, payload.limit);
            }
            catch (System.Exception e)
            {
                return BadRequest(new Response<string>
                {
                    Message = "Erro ao buscar os UserCustomizationss",
                    Data = e.Message,
                    Success = false,
                    StatusCode = 400

                });

            }
            return Ok(result);
        }

        [HttpGet("{id}")]
        [Authorize]
        public async Task<ActionResult<Response<UserCustomizations>>> getById(int id)
        {
            Response<UserCustomizationsDTO> response = null;

            try
            {
                UserCustomizationsDTO result = await this._UserCustomizationsRepository.GetById(id);
                if (result != null)
                {
                    response = new Response<UserCustomizationsDTO>
                    {
                        Message = "UserCustomizations encontrado com sucesso",
                        Data = result,
                        Success = true,
                        StatusCode = 200
                    };
                }
                else
                {
                    response = new Response<UserCustomizationsDTO>
                    {
                        Message = "UserCustomizations não encontrado",
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
                    Message = "Erro ao buscar o UserCustomizations",
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
        public async Task<ActionResult<Response<bool>>> create(UserCustomizations UserCustomizations)
        {
            Response<bool> response = null;

            try
            {
                var result = await this._UserCustomizationsRepository.Create(UserCustomizations);
                if (result)
                {
                    response = new Response<bool>
                    {
                        Message = "UserCustomizations criada com sucesso",
                        Data = result,
                        Success = true,
                        StatusCode = 200
                    };
                }
                else
                {
                    response = new Response<bool>
                    {
                        Message = "UserCustomizations não criado",
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
                    Message = "Erro ao criar o UserCustomizations",
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
        public async Task<ActionResult<Response<bool>>> update(UserCustomizations UserCustomizations)
        {
            Response<bool> response = null;
            try
            {
                var result = await this._UserCustomizationsRepository.Update(UserCustomizations);
                if (result)
                {
                    response = new Response<bool>
                    {
                        Message = "UserCustomizations atualizado com sucesso",
                        Data = result,
                        Success = true,
                        StatusCode = 200
                    };
                }
                else
                {
                    response = new Response<bool>
                    {
                        Message = "UserCustomizations não atualizado",
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
                    Message = "Erro ao atualizar o UserCustomizations",
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
                var result = await this._UserCustomizationsRepository.Delete(id);
                if (result)
                {
                    response = new Response<bool>
                    {
                        Message = "UserCustomizations excluido com sucesso",
                        Data = result,
                        Success = true,
                        StatusCode = 200
                    };
                }
                else
                {
                    response = new Response<bool>
                    {
                        Message = "UserCustomizations não excluido",
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
                    Message = "Erro ao excluir o UserCustomizations",
                    Data = e.Message,
                    Success = false,
                    StatusCode = 400
                });
            }
        }


    }

}
