using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using back.data.entities.AnexoRep;
using back.data.http;
using back.domain.DTO.AnexoRep;
using back.domain.Repositories;
using back.infra.Data.Context;
using back.infra.Services.AnexoRepServices;
using back.MappingConfig;
using Microsoft.EntityFrameworkCore;

namespace back.infra.Data.Repositories
{
    public class AnexoRepRepository : ValidPagination, IAnexoRepRepository
    {
        private readonly IMapper _mapper;
        private readonly DbContexts _ctxs;

        public AnexoRepRepository(DbContexts ctxs) : base()
        {
            this._mapper = MapperConfig.MapperConfiguration().CreateMapper();
            _ctxs = ctxs;

        }

        public async Task<Response<List<AnexoRepDTO>>> GetAllPaginateAsync(int page, int limit)
        {
            var response = new Response<List<AnexoRepDTO>>();
            var contexto = _ctxs.GetVFU();
            try
            {
                base.ValidPaginate(page, limit);
                var savedSearches = contexto.AnexoRep.Include(e => e.Empresa).Skip(base.skip).OrderBy(o => o.Id).Take(base.limit);

                List<AnexoRepDTO> dTOs = new List<AnexoRepDTO>();

                var AnexoReps = await savedSearches.ToListAsync();
                AnexoReps.ForEach(e => dTOs.Add(_mapper.Map<AnexoRepDTO>(e)));

                response.Data = dTOs;
                response.TotalPages = await contexto.AnexoRep.CountAsync();
                response.Page = page;
                response.TotalPages = base.getTotalPages(response.TotalPages);
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

        public async Task<AnexoRepDTO> GetById(int id)
        {
            return _mapper.Map<AnexoRepDTO>(await this._ctxs.
            GetVFU()
            .GetByIdService(id));
        }

        public Task<bool> Create(AnexoRep AnexoRep)
        {
            try
            {
                return _ctxs.GetVFU().Create(AnexoRep);
            }
            catch (Exception e)
            {
                return BadRequest(new Response<string>
                {
                    Message = "Erro ao criar AnexoRep",
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
                    Message = "Erro ao deletar AnexoRep.",
                    Data = e.Message,
                    Success = false,
                    StatusCode = 400
                });
            }
        }

        public Task<bool> Update(AnexoRep AnexoRep)
        {
            if (AnexoRep.Id == 0)
            {
                return BadRequest(new Response<string>
                {
                    Message = "Id não informado",
                    Data = "",
                    Success = false,
                    StatusCode = 400
                });
            }
            return _ctxs.GetVFU().UpdateAnexoRepServices(_mapper.Map<AnexoRepDTOUpdateDTO>(AnexoRep), AnexoRep.Id);
        }
    }
}