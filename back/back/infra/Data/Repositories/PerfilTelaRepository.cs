using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using back.data.entities.ProfileScreen;
using back.data.http;
using back.domain.DTO.ProfileScreenDTO;
using back.domain.Repositories;
using back.infra.Data.Context;
using back.infra.Services.PerfilTelaServices;
using back.MappingConfig;
using Microsoft.EntityFrameworkCore;

namespace back.infra.Data.Repositories
{
    public class PerfilTelaRepository : ValidPagination, IPerfilTelaRepository
    {
        private readonly IMapper _mapper;
        private readonly DbContexts _ctxs;

        public PerfilTelaRepository(DbContexts ctxs) : base()
        {
            this._mapper = MapperConfig.MapperConfiguration().CreateMapper();
            _ctxs = ctxs;
        }
        public Task<bool> Create(PerfilTelaDTOCreate perfilTela)
        {
            try
            {
                return _ctxs.GetVFU().Create(perfilTela);
            }
            catch (System.Exception e)
            {
                return BadRequest(new Response<string>
                {
                    Message = "Erro ao criar perfil tela",
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
            catch (System.Exception e)
            {
                return BadRequest(new Response<string>
                {
                    Message = "Erro ao deletar perfil tela",
                    Data = e.Message,
                    Success = false,
                    StatusCode = 400
                });
            }
        }

        public async Task<Response<List<PerfilTelaDTO>>> GetAllPaginateAsync(int page, int limit)
        {
            var response = new Response<List<PerfilTelaDTO>>();
            var contexto = _ctxs.GetVFU();
            try
            {
                base.ValidPaginate(page, limit);
                var savedSearches = contexto.PerfilTela.Include(p => p.Perfil).ThenInclude(u => u.Usuario).Include(e => e.Telas).Skip(base.skip).OrderBy(o => o.Id).Take(base.limit);

                List<PerfilTelaDTO> dTOs = new List<PerfilTelaDTO>();

                var perfiltelas = await savedSearches.ToListAsync();
                perfiltelas.ForEach(e => dTOs.Add(_mapper.Map<PerfilTelaDTO>(e)));

                response.Data = dTOs;
                response.TotalPages = await contexto.PerfilTela.CountAsync();
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

        public async Task<PerfilTelaDTO> GetById(int id)
        {
            var result = await this._ctxs.GetVFU().GetByIdService(id);
            return _mapper.Map<PerfilTelaDTO>(result);
        }

        public PerfilTelaDTO GetByIdAsync(int id)
        {
            throw new System.NotImplementedException();
        }

        public Task<bool> Update(PerfilTelaDTOUpdateDTO perfilTela)
        {
            if (perfilTela.Id == 0)
            {
                return BadRequest(new Response<string>
                {
                    Message = "Id n??o informado",
                    Data = "",
                    Success = false,
                    StatusCode = 400
                });
            }
            return _ctxs.GetVFU().UpdatePerfilTelaServices(_mapper.Map<PerfilTelaDTOUpdateDTO>(perfilTela), perfilTela.Id);
        }

        public Task<Response<List<PerfilTelaDTO>>> GetByUsuarioId(int userId)
        {
            //TODO get by usuario id
            throw new NotImplementedException();
        }
    }
}