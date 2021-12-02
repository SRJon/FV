using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using back.data.entities.Parametro;
using back.data.http;
using back.domain.DTO.Parametro;
using back.domain.Repositories;
using back.infra.Data.Context;
using back.infra.Services.ParametroServices;
using back.MappingConfig;
using Microsoft.EntityFrameworkCore;

namespace back.infra.Data.Repositories
{
    public class ParametroRepository : ValidPagination, IParametroRepository
    {
        private readonly IMapper _mapper;
        private readonly DbContexts _ctxs;

        public ParametroRepository(DbContexts ctxs) : base()
        {
            this._mapper = MapperConfig.MapperConfiguration().CreateMapper();
            _ctxs = ctxs;

        }

        public async Task<Response<List<ParametroDTO>>> GetAllPaginateAsync(int page, int limit)
        {
            var response = new Response<List<ParametroDTO>>();
            var contexto = _ctxs.GetVFU();
            try
            {
                base.ValidPaginate(page, limit);
                var savedSearches = contexto.Parametro.Skip(base.skip).OrderBy(o => o.Id).Take(base.limit);

                List<ParametroDTO> dTOs = new List<ParametroDTO>();

                var Parametros = await savedSearches.ToListAsync();
                Parametros.ForEach(e => dTOs.Add(_mapper.Map<ParametroDTO>(e)));

                response.Data = dTOs;
                response.TotalPages = await contexto.Parametro.CountAsync();
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

        public async Task<ParametroDTO> GetById(int id)
        {
            return _mapper.Map<ParametroDTO>(await this._ctxs.
            GetVFU()
            .GetByIdService(id));
        }

        public Task<bool> Create(Parametro Parametro)
        {
            try
            {
                return _ctxs.GetVFU().Create(Parametro);
            }
            catch (Exception e)
            {
                return BadRequest(new Response<string>
                {
                    Message = "Erro ao criar Parametro",
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
                    Message = "Erro ao deletar Parametro.",
                    Data = e.Message,
                    Success = false,
                    StatusCode = 400
                });
            }
        }

        public Task<bool> Update(Parametro Parametro)
        {
            if (Parametro.Id == 0)
            {
                return BadRequest(new Response<string>
                {
                    Message = "Id não informado",
                    Data = "",
                    Success = false,
                    StatusCode = 400
                });
            }
            return _ctxs.GetVFU().UpdateParametroServices(_mapper.Map<ParametroDTOUpdateDTO>(Parametro), Parametro.Id);
        }
    }
}