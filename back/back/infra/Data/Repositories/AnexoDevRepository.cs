using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using back.data.entities.AnexoDev;
using back.data.http;
using back.domain.DTO.AnexoDev;
using back.domain.Repositories;
using back.infra.Data.Context;
using back.infra.Services.AnexoDevServices;
using back.MappingConfig;
using Microsoft.EntityFrameworkCore;

namespace back.infra.Data.Repositories
{
    public class AnexoDevRepository : ValidPagination, IAnexoDevRepository
    {
        private readonly IMapper _mapper;
        private readonly DbContexts _ctxs;

        public AnexoDevRepository(DbContexts ctxs) : base()
        {
            this._mapper = MapperConfig.MapperConfiguration().CreateMapper();
            _ctxs = ctxs;

        }

        public async Task<Response<List<AnexoDevDTO>>> GetAllPaginateAsync(int page, int limit)
        {
            var response = new Response<List<AnexoDevDTO>>();
            var contexto = _ctxs.GetVFU();
            try
            {
                base.ValidPaginate(page, limit);
                var savedSearches = contexto.AnexoDev.Skip(base.skip).OrderBy(o => o.Id).Take(base.limit);

                List<AnexoDevDTO> dTOs = new List<AnexoDevDTO>();

                var AnexoDevs = await savedSearches.ToListAsync();
                AnexoDevs.ForEach(e => dTOs.Add(_mapper.Map<AnexoDevDTO>(e)));

                response.Data = dTOs;
                response.TotalPages = await contexto.AnexoDev.CountAsync();
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

        public async Task<AnexoDevDTO> GetById(int id)
        {
            return _mapper.Map<AnexoDevDTO>(await this._ctxs.
            GetVFU()
            .GetByIdService(id));
        }

        public Task<bool> Create(AnexoDev AnexoDev)
        {
            try
            {
                return _ctxs.GetVFU().Create(AnexoDev);
            }
            catch (Exception e)
            {
                return BadRequest(new Response<string>
                {
                    Message = "Erro ao criar AnexoDev",
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
                    Message = "Erro ao deletar AnexoDev.",
                    Data = e.Message,
                    Success = false,
                    StatusCode = 400
                });
            }
        }

        public Task<bool> Update(AnexoDev AnexoDev)
        {
            if (AnexoDev.Id == 0)
            {
                return BadRequest(new Response<string>
                {
                    Message = "Id n??o informado",
                    Data = "",
                    Success = false,
                    StatusCode = 400
                });
            }
            return _ctxs.GetVFU().UpdateAnexoDevServices(_mapper.Map<AnexoDevDTOUpdateDTO>(AnexoDev), AnexoDev.Id);
        }
    }
}