
using AutoMapper;
using back.data.entities.UserEmp;
using back.data.http;
using back.domain.DTO.UserEmp;
using back.domain.Repositories;
using back.infra.Data.Context;
using back.infra.Services.UserEmpServices;
using back.MappingConfig;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace back.infra.Data.Repositories
{
    public class UsuarioEmpRepository : ValidPagination, IUsuarioEmpRepository
    {
        private readonly IMapper _mapper;
        private readonly DbContexts _ctxs;

        public UsuarioEmpRepository(DbContexts ctxs) : base()
        {
            this._mapper = MapperConfig.MapperConfiguration().CreateMapper();
            _ctxs = ctxs;

        }

        public async Task<Response<List<UsuarioEmpDTO>>> GetAllPaginateAsync(int page, int limit)
        {
            var response = new Response<List<UsuarioEmpDTO>>();
            var contexto = _ctxs.GetVFU();
            try
            {
                base.ValidPaginate(page, limit);
                var savedSearches = contexto.UsuarioEmp.Skip(base.skip).OrderBy(o => o.Id).Take(base.limit);

                List<UsuarioEmpDTO> dTOs = new List<UsuarioEmpDTO>();

                var UsuarioEmps = await savedSearches.ToListAsync();
                UsuarioEmps.ForEach(e => dTOs.Add(_mapper.Map<UsuarioEmpDTO>(e)));

                response.Data = dTOs;
                response.TotalPages = await contexto.UsuarioEmp.CountAsync();
                response.Page = page;
                response.TotalPages = (response.TotalPages / base.limit) + 1;
                response.TotalPages = response.TotalPages == 0 ? 0 : response.TotalPages;
                response.Success = true;
                response.StatusCode = 200;
                return response;
            }
            catch (Exception)
            {
                response.Data = null;
                response.StatusCode = 400;
                return response;
            }
        }

        public async Task<UsuarioEmpDTO> GetById(int id)
        {
            return _mapper.Map<UsuarioEmpDTO>(await this._ctxs.
            GetVFU()
            .GetByIdService(id));
        }

        public Task<bool> Create(UsuarioEmp UsuarioEmp)
        {
            try
            {
                return _ctxs.GetVFU().Create(UsuarioEmp);
            }
            catch (Exception e)
            {
                return BadRequest(new Response<string>
                {
                    Message = "Erro ao criar UsuarioEmp",
                    Data = e.Message,
                    Success = false,
                    StatusCode = 400
                });
            }
        }

        private Task<bool> BadRequest(Response<string> response)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Delete(int id)
        {
            try
            {
                return _ctxs.GetVFU().Delete(id);
            }
            catch (Exception e)
            {
                return BadRequest(new Response<string>
                {
                    Message = "Erro ao deletar UsuarioEmp.",
                    Data = e.Message,
                    Success = false,
                    StatusCode = 400
                });
            }
        }

        public Task<bool> Update(UsuarioEmp UsuarioEmp)
        {
            if (UsuarioEmp.Id == 0)
            {
                return BadRequest(new Response<string>
                {
                    Message = "Id não informado",
                    Data = "",
                    Success = false,
                    StatusCode = 400
                });
            }
            return _ctxs.GetVFU().UpdateUsuarioEmpServices(_mapper.Map<UsuarioEmpDTOUpdateDTO>(UsuarioEmp), UsuarioEmp.Id);
        }
    }
}
