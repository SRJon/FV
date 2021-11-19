using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using back.data.entities.AnexoCont;
using back.data.http;
using back.domain.DTO.AnexoCont;
using back.domain.Repositories;
using back.infra.Data.Context;
using back.infra.Services.AnexoContServices;
using back.MappingConfig;
using Microsoft.EntityFrameworkCore;

namespace back.infra.Data.Repositories
{
    public class AnexoContRepository : ValidPagination, IAnexoContRepository
    {
        private readonly IMapper _mapper;
        private readonly DbContexts _ctxs;

        public AnexoContRepository(DbContexts ctxs) : base()
        {
            this._mapper = MapperConfig.MapperConfiguration().CreateMapper();
            _ctxs = ctxs;

        }

        public async Task<Response<List<AnexoContDTO>>> GetAllPaginateAsync(int page, int limit)
        {
            var response = new Response<List<AnexoContDTO>>();
            var contexto = _ctxs.GetVFU();
            try
            {
                base.ValidPaginate(page, limit);
                var savedSearches = contexto.AnexoCont.Skip(base.skip).OrderBy(o => o.Id).Take(base.limit);

                List<AnexoContDTO> dTOs = new List<AnexoContDTO>();

                var AnexoConts = await savedSearches.ToListAsync();
                AnexoConts.ForEach(e => dTOs.Add(_mapper.Map<AnexoContDTO>(e)));

                response.Data = dTOs;
                response.TotalPages = await contexto.AnexoCont.CountAsync();
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

        public async Task<AnexoContDTO> GetById(int id)
        {
            return _mapper.Map<AnexoContDTO>(await this._ctxs.
            GetVFU()
            .GetByIdService(id));
        }

        public Task<bool> Create(AnexoCont AnexoCont)
        {
            try
            {
                return _ctxs.GetVFU().Create(AnexoCont);
            }
            catch (Exception e)
            {
                return BadRequest(new Response<string>
                {
                    Message = "Erro ao criar AnexoCont",
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
                    Message = "Erro ao deletar AnexoCont.",
                    Data = e.Message,
                    Success = false,
                    StatusCode = 400
                });
            }
        }

        public Task<bool> Update(AnexoCont AnexoCont)
        {
            if (AnexoCont.Id == 0)
            {
                return BadRequest(new Response<string>
                {
                    Message = "Id não informado",
                    Data = "",
                    Success = false,
                    StatusCode = 400
                });
            }
            return _ctxs.GetVFU().UpdateAnexoContServices(_mapper.Map<AnexoContDTOUpdateDTO>(AnexoCont), AnexoCont.Id);
        }
    }
}