using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using back.data.entities.Diretorio;
using back.data.http;
using back.domain.DTO.Diretorio;
using back.domain.Repositories;
using back.infra.Data.Context;
using back.infra.Services.DiretorioServices;
using back.MappingConfig;
using Microsoft.EntityFrameworkCore;

namespace back.infra.Data.Repositories
{
    public class DiretorioRepository : ValidPagination, IDiretorioRepository
    {
        private readonly IMapper _mapper;
        private readonly DbContexts _ctxs;

        public DiretorioRepository(DbContexts ctxs) : base()
        {
            this._mapper = MapperConfig.MapperConfiguration().CreateMapper();
            _ctxs = ctxs;

        }

        public async Task<Response<List<DiretorioDTO>>> GetAllPaginateAsync(int page, int limit)
        {
            var response = new Response<List<DiretorioDTO>>();
            var contexto = _ctxs.GetVFU();
            try
            {
                base.ValidPaginate(page, limit);
                var savedSearches = contexto.Diretorio.Skip(base.skip).OrderBy(o => o.Id).Take(base.limit);

                List<DiretorioDTO> dTOs = new List<DiretorioDTO>();

                var Diretorios = await savedSearches.ToListAsync();
                Diretorios.ForEach(e => dTOs.Add(_mapper.Map<DiretorioDTO>(e)));

                response.Data = dTOs;
                response.TotalPages = await contexto.Diretorio.CountAsync();
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

        public async Task<DiretorioDTO> GetById(int id)
        {
            return _mapper.Map<DiretorioDTO>(await this._ctxs.
            GetVFU()
            .GetByIdService(id));
        }

        public Task<bool> Create(Diretorio Diretorio)
        {
            try
            {
                return _ctxs.GetVFU().Create(Diretorio);
            }
            catch (Exception e)
            {
                return BadRequest(new Response<string>
                {
                    Message = "Erro ao criar Diretorio",
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
                    Message = "Erro ao deletar Diretorio.",
                    Data = e.Message,
                    Success = false,
                    StatusCode = 400
                });
            }
        }

        public Task<bool> Update(Diretorio Diretorio)
        {
            if (Diretorio.Id == 0)
            {
                return BadRequest(new Response<string>
                {
                    Message = "Id não informado",
                    Data = "",
                    Success = false,
                    StatusCode = 400
                });
            }
            return _ctxs.GetVFU().UpdateDiretorioServices(_mapper.Map<DiretorioDTOUpdateDTO>(Diretorio), Diretorio.Id);
        }
    }
}