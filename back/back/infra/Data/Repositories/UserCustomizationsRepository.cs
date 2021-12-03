using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using back.data.entities.UserCustomizations;
using back.data.http;
using back.domain.DTO.UserCustomizations;
using back.domain.Repositories;
using back.infra.Data.Context;
using back.infra.Services.UserCustomizationsServices;
using back.MappingConfig;
using Microsoft.EntityFrameworkCore;

namespace back.infra.Data.Repositories
{
    public class UserCustomizationsRepository : ValidPagination, IUserCustomizationsRepository
    {
        private readonly IMapper _mapper;
        private readonly DbContexts _ctxs;

        public UserCustomizationsRepository(DbContexts ctxs) : base()
        {
            this._mapper = MapperConfig.MapperConfiguration().CreateMapper();
            _ctxs = ctxs;

        }

        public async Task<Response<List<UserCustomizationsDTO>>> GetAllPaginateAsync(int page, int limit)
        {
            var response = new Response<List<UserCustomizationsDTO>>();
            var contexto = _ctxs.GetVFU();
            try
            {
                base.ValidPaginate(page, limit);
                var savedSearches = contexto.UserCustomizations.Skip(base.skip).OrderBy(o => o.Id).Take(base.limit);

                List<UserCustomizationsDTO> dTOs = new List<UserCustomizationsDTO>();

                var UserCustomizationss = await savedSearches.ToListAsync();
                UserCustomizationss.ForEach(e => dTOs.Add(_mapper.Map<UserCustomizationsDTO>(e)));

                response.Data = dTOs;
                response.TotalPages = await contexto.UserCustomizations.CountAsync();
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

        public async Task<UserCustomizationsDTO> GetById(int id)
        {
            return _mapper.Map<UserCustomizationsDTO>(await this._ctxs.
            GetVFU()
            .GetByIdService(id));
        }

        public Task<bool> Create(UserCustomizations UserCustomizations)
        {
            try
            {
                return _ctxs.GetVFU().Create(UserCustomizations);
            }
            catch (Exception e)
            {
                return BadRequest(new Response<string>
                {
                    Message = "Erro ao criar UserCustomizations",
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
                    Message = "Erro ao deletar UserCustomizations.",
                    Data = e.Message,
                    Success = false,
                    StatusCode = 400
                });
            }
        }

        public Task<bool> Update(UserCustomizations UserCustomizations)
        {
            if (UserCustomizations.Id == 0)
            {
                return BadRequest(new Response<string>
                {
                    Message = "Id não informado",
                    Data = "",
                    Success = false,
                    StatusCode = 400
                });
            }
            return _ctxs.GetVFU().UpdateUserCustomizationsServices(_mapper.Map<UserCustomizationsDTOUpdateDTO>(UserCustomizations), UserCustomizations.Id);
        }
    }
}