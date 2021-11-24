using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using back.data.entities.Profile;
using back.data.http;
using back.domain.DTO.ProfileDTO;
using back.domain.Repositories;
using back.infra.Data.Context;
using back.infra.Services.PerfilServices;
using back.MappingConfig;
using Microsoft.EntityFrameworkCore;

namespace back.infra.Data.Repositories
{
    public class PerfilRepository : ValidPagination, IPerfilRepository
    {
        private readonly IMapper _mapper;
        private readonly DbContexts _ctxs;

        public PerfilRepository(DbContexts ctxs) : base()
        {
            this._mapper = MapperConfig.MapperConfiguration().CreateMapper();
            _ctxs = ctxs;
        }
        public Task<bool> Create(PerfilDTOCreate perfil)
        {
            try
            {
                return _ctxs.GetVFU().Create(perfil);
            }
            catch (Exception e)
            {

                return BadRequest(new Response<string>
                {
                    Message = "Erro ao criar perfil",
                    Data = e.Message,
                    Success = false,
                    StatusCode = 400
                });
            }
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
                    Message = "Erro ao deletar perfil",
                    Data = e.Message,
                    Success = false,
                    StatusCode = 400
                });
            }
        }

        public async Task<Response<List<PerfilDTO>>> GetAllPaginateAsync(int page, int limit)
        {
            var response = new Response<List<PerfilDTO>>();
            var contexto = _ctxs.GetVFU();
            try
            {
                base.ValidPaginate(page, limit);
                var savedSearches = contexto.Perfil.Include(u => u.Usuario).Include(p => p.PerfilTela).ThenInclude(t => t.Telas).Skip(base.skip).OrderBy(o => o.Id).Take(base.limit);//.Include(x => x.Parameters);

                List<PerfilDTO> dTOs = new List<PerfilDTO>();

                var perfis = await savedSearches.ToListAsync();
                perfis.ForEach(e => dTOs.Add(_mapper.Map<PerfilDTO>(e)));

                response.Data = dTOs;
                response.TotalPages = await contexto.Perfil.CountAsync();
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

        public async Task<PerfilDTO> GetById(int id)
        {
            return _mapper.Map<PerfilDTO>(await this._ctxs
            .GetVFU()
            .GetByIdService(id));
        }

        public PerfilDTO GetByIdAsync(int id)
        {
            var response = new Response<Perfil>();
            try
            {
                return _mapper.Map<PerfilDTO>(this._ctxs
            .GetVFU()
            .GetByIdAsyncService(id));
            }
            catch (System.Exception e)
            {
                System.Console.WriteLine(e);
                return null;
            }
        }

        public async Task<PerfilDTONome> GetNameById(int id)
        {
            return _mapper.Map<PerfilDTONome>(await this._ctxs
             .GetVFU()
             .GetNameByIdService(id));
        }

        public Task<bool> Update(PerfilDTOUpdateDTO perfil)
        {
            if (perfil.Id == 0)
            {
                return BadRequest(new Response<string>
                {
                    Message = "Id não informado",
                    Data = "",
                    Success = false,
                    StatusCode = 400
                });
            }
            return _ctxs.GetVFU().UpdatePerfilServices(_mapper.Map<PerfilDTOUpdateDTO>(perfil), perfil.Id);
        }

        private Task<bool> BadRequest(Response<string> response)
        {
            throw new NotImplementedException();
        }

    }
}