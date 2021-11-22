using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using back.data.entities.Informativo;
using back.data.http;
using back.domain.DTO.Informativo;
using back.domain.Repositories;
using back.infra.Data.Context;
using back.infra.Services.InformativoServices;
using back.MappingConfig;
using Microsoft.EntityFrameworkCore;

namespace back.infra.Data.Repositories
{
    public class InformativoRepository : ValidPagination, IInformativoRepository
    {
        private readonly IMapper _mapper;
        private readonly DbContexts _ctxs;

        public InformativoRepository(DbContexts ctxs) : base()
        {
            this._mapper = MapperConfig.MapperConfiguration().CreateMapper();
            _ctxs = ctxs;

        }

        public async Task<Response<List<InformativoDTO>>> GetAllPaginateAsync(int page, int limit)
        {
            var response = new Response<List<InformativoDTO>>();
            var contexto = _ctxs.GetVFU();
            try
            {
                base.ValidPaginate(page, limit);
                var savedSearches = contexto.Informativo.Skip(base.skip).OrderBy(o => o.Id).Take(base.limit);

                List<InformativoDTO> dTOs = new List<InformativoDTO>();

                var Informativos = await savedSearches.ToListAsync();
                Informativos.ForEach(e => dTOs.Add(_mapper.Map<InformativoDTO>(e)));

                response.Data = dTOs;
                response.TotalPages = await contexto.Informativo.CountAsync();
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

        public async Task<InformativoDTO> GetById(int id)
        {
            return _mapper.Map<InformativoDTO>(await this._ctxs.
            GetVFU()
            .GetByIdService(id));
        }

        public Task<bool> Create(Informativo Informativo)
        {
            try
            {
                return _ctxs.GetVFU().Create(Informativo);
            }
            catch (Exception e)
            {
                return BadRequest(new Response<string>
                {
                    Message = "Erro ao criar Informativo",
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
                    Message = "Erro ao deletar Informativo.",
                    Data = e.Message,
                    Success = false,
                    StatusCode = 400
                });
            }
        }

        public Task<bool> Update(Informativo Informativo)
        {
            if (Informativo.Id == 0)
            {
                return BadRequest(new Response<string>
                {
                    Message = "Id não informado",
                    Data = "",
                    Success = false,
                    StatusCode = 400
                });
            }
            return _ctxs.GetVFU().UpdateInformativoServices(_mapper.Map<InformativoDTOUpdateDTO>(Informativo), Informativo.Id);
        }
    }
}