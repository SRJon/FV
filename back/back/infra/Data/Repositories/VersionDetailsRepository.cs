using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using back.data.entities.VersionDetails;
using back.data.http;
using back.domain.DTO.VersionDetails;
using back.domain.Repositories;
using back.infra.Data.Context;
using back.infra.Services.VersionDetailsServices;
using back.MappingConfig;
using Microsoft.EntityFrameworkCore;

namespace back.infra.Data.Repositories
{
    public class VersionDetailsRepository : ValidPagination, IVersionDetailsRepository
    {
        private readonly IMapper _mapper;
        private readonly DbContexts _ctxs;

        public VersionDetailsRepository(DbContexts ctxs) : base()
        {
            this._mapper = MapperConfig.MapperConfiguration().CreateMapper();
            _ctxs = ctxs;

        }

        public async Task<Response<List<VersionDetailsDTO>>> GetAllPaginateAsync(int page, int limit)
        {
            var response = new Response<List<VersionDetailsDTO>>();
            var contexto = _ctxs.GetVFU();
            try
            {
                base.ValidPaginate(page, limit);
                var savedSearches = contexto.VersionDetails.Skip(base.skip).OrderBy(o => o.Id).Take(base.limit);

                List<VersionDetailsDTO> dTOs = new List<VersionDetailsDTO>();

                var VersionDetailss = await savedSearches.ToListAsync();
                VersionDetailss.ForEach(e => dTOs.Add(_mapper.Map<VersionDetailsDTO>(e)));

                response.Data = dTOs;
                response.TotalPages = await contexto.VersionDetails.CountAsync();
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

        public async Task<VersionDetailsDTO> GetById(int id)
        {
            return _mapper.Map<VersionDetailsDTO>(await this._ctxs.
            GetVFU()
            .GetByIdService(id));
        }

        public Task<bool> Create(VersionDetails VersionDetails)
        {
            try
            {
                return _ctxs.GetVFU().Create(VersionDetails);
            }
            catch (Exception e)
            {
                return BadRequest(new Response<string>
                {
                    Message = "Erro ao criar VersionDetails",
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
                    Message = "Erro ao deletar VersionDetails.",
                    Data = e.Message,
                    Success = false,
                    StatusCode = 400
                });
            }
        }

        public Task<bool> Update(VersionDetails VersionDetails)
        {
            if (VersionDetails.Id == 0)
            {
                return BadRequest(new Response<string>
                {
                    Message = "Id não informado",
                    Data = "",
                    Success = false,
                    StatusCode = 400
                });
            }
            return _ctxs.GetVFU().UpdateVersionDetailsServices(_mapper.Map<VersionDetailsDTOUpdateDTO>(VersionDetails), VersionDetails.Id);
        }
    }
}