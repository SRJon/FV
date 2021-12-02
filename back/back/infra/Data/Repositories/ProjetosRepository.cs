using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using back.data.entities.Projetos;
using back.data.http;
using back.domain.DTO.Projetos;
using back.domain.Repositories;
using back.infra.Data.Context;
using back.infra.Services.ProjetosServices;
using back.MappingConfig;
using Microsoft.EntityFrameworkCore;

namespace back.infra.Data.Repositories
{
    public class ProjetosRepository : ValidPagination, IProjetosRepository
    {
        private readonly IMapper _mapper;
        private readonly DbContexts _ctxs;

        public ProjetosRepository(DbContexts ctxs) : base()
        {
            this._mapper = MapperConfig.MapperConfiguration().CreateMapper();
            _ctxs = ctxs;

        }

        public async Task<Response<List<ProjetosDTO>>> GetAllPaginateAsync(int page, int limit)
        {
            var response = new Response<List<ProjetosDTO>>();
            var contexto = _ctxs.GetVFU();
            try
            {
                base.ValidPaginate(page, limit);
                var savedSearches = contexto.Projetos.Skip(base.skip).OrderBy(o => o.Id).Take(base.limit);

                List<ProjetosDTO> dTOs = new List<ProjetosDTO>();

                var Projetoss = await savedSearches.ToListAsync();
                Projetoss.ForEach(e => dTOs.Add(_mapper.Map<ProjetosDTO>(e)));

                response.Data = dTOs;
                response.TotalPages = await contexto.Projetos.CountAsync();
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

        public async Task<ProjetosDTO> GetById(int id)
        {
            return _mapper.Map<ProjetosDTO>(await this._ctxs.
            GetVFU()
            .GetByIdService(id));
        }

        public Task<bool> Create(Projetos Projetos)
        {
            try
            {
                return _ctxs.GetVFU().Create(Projetos);
            }
            catch (Exception e)
            {
                return BadRequest(new Response<string>
                {
                    Message = "Erro ao criar Projetos",
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
                    Message = "Erro ao deletar Projetos.",
                    Data = e.Message,
                    Success = false,
                    StatusCode = 400
                });
            }
        }

        public Task<bool> Update(Projetos Projetos)
        {
            if (Projetos.Id == 0)
            {
                return BadRequest(new Response<string>
                {
                    Message = "Id não informado",
                    Data = "",
                    Success = false,
                    StatusCode = 400
                });
            }
            return _ctxs.GetVFU().UpdateProjetosServices(_mapper.Map<ProjetosDTOUpdateDTO>(Projetos), Projetos.Id);
        }
    }
}