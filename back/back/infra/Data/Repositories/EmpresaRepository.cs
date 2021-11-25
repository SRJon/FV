using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using back.data.entities.Enterprise;
using back.data.http;
using back.domain.DTO.Enterprise;
using back.domain.Repositories;
using back.infra.Data.Context;
using back.infra.Services.EmpresaServices;
using back.MappingConfig;
using Microsoft.EntityFrameworkCore;

namespace back.infra.Data.Repositories
{
    public class EmpresaRepository : ValidPagination, IEmpresaRepository
    {
        private readonly IMapper _mapper;
        private readonly DbContexts _ctxs;

        public EmpresaRepository(DbContexts ctxs) : base()
        {
            this._mapper = MapperConfig.MapperConfiguration().CreateMapper();
            _ctxs = ctxs;

        }

        public async Task<Response<List<EmpresaDTO>>> GetAllPaginateAsync(int page, int limit)
        {
            var response = new Response<List<EmpresaDTO>>();
            var contexto = _ctxs.GetVFU();
            try
            {
                base.ValidPaginate(page, limit);
                var savedSearches = contexto.Empresa.Skip(base.skip).OrderBy(o => o.Id).Take(base.limit);

                List<EmpresaDTO> dTOs = new List<EmpresaDTO>();

                var empresas = await savedSearches.ToListAsync();
                empresas.ForEach(e => dTOs.Add(_mapper.Map<EmpresaDTO>(e)));

                response.Data = dTOs;
                response.TotalPages = await contexto.Empresa.CountAsync();
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

        public async Task<EmpresaDTO> GetById(int id)
        {
            return _mapper.Map<EmpresaDTO>(await this._ctxs.
            GetVFU()
            .GetByIdService(id));
        }

        public Task<bool> Create(Empresa empresa)
        {
            try
            {
                return _ctxs.GetVFU().Create(empresa);
            }
            catch (Exception e)
            {
                return BadRequest(new Response<string>
                {
                    Message = "Erro ao criar empresa",
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
                    Message = "Erro ao deletar empresa.",
                    Data = e.Message,
                    Success = false,
                    StatusCode = 400
                });
            }
        }

        public Task<bool> Update(Empresa empresa)
        {
            if (empresa.Id == 0)
            {
                return BadRequest(new Response<string>
                {
                    Message = "Id não informado",
                    Data = "",
                    Success = false,
                    StatusCode = 400
                });
            }
            return _ctxs.GetVFU().UpdateEmpresaServices(_mapper.Map<EmpresaDTOUpdateDTO>(empresa), empresa.Id);
        }
    }
}