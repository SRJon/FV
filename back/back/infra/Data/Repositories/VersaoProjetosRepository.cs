using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using back.data.entities.VersaoProjetos;
using back.data.http;
using back.domain.DTO.VersaoProjetos;
using back.domain.Repositories;
using back.infra.Data.Context;
using back.infra.Services.VersaoProjetosServices;
using back.MappingConfig;
using Microsoft.EntityFrameworkCore;

namespace back.infra.Data.Repositories
{
    public class VersaoProjetosRepository : ValidPagination, IVersaoProjetosRepository
    {
        private readonly IMapper _mapper;
        private readonly DbContexts _ctxs;

        public VersaoProjetosRepository(DbContexts ctxs) : base()
        {
            this._mapper = MapperConfig.MapperConfiguration().CreateMapper();
            _ctxs = ctxs;

        }

        public async Task<Response<List<VersaoProjetosDTO>>> GetAllPaginateAsync(int page, int limit)
        {
            var response = new Response<List<VersaoProjetosDTO>>();
            var contexto = _ctxs.GetVFU();
            try
            {
                base.ValidPaginate(page, limit);
                var savedSearches = contexto.VersaoProjetos.Skip(base.skip).OrderBy(o => o.Id).Take(base.limit);

                List<VersaoProjetosDTO> dTOs = new List<VersaoProjetosDTO>();

                var VersaoProjetoss = await savedSearches.ToListAsync();
                VersaoProjetoss.ForEach(e => dTOs.Add(_mapper.Map<VersaoProjetosDTO>(e)));

                response.Data = dTOs;
                response.TotalPages = await contexto.VersaoProjetos.CountAsync();
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

        public async Task<VersaoProjetosDTO> GetById(int id)
        {
            return _mapper.Map<VersaoProjetosDTO>(await this._ctxs.
            GetVFU()
            .GetByIdService(id));
        }

        public Task<bool> Create(VersaoProjetos VersaoProjetos)
        {
            try
            {
                return _ctxs.GetVFU().Create(VersaoProjetos);
            }
            catch (Exception e)
            {
                return BadRequest(new Response<string>
                {
                    Message = "Erro ao criar VersaoProjetos",
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
                    Message = "Erro ao deletar VersaoProjetos.",
                    Data = e.Message,
                    Success = false,
                    StatusCode = 400
                });
            }
        }

        public Task<bool> Update(VersaoProjetos VersaoProjetos)
        {
            if (VersaoProjetos.Id == 0)
            {
                return BadRequest(new Response<string>
                {
                    Message = "Id não informado",
                    Data = "",
                    Success = false,
                    StatusCode = 400
                });
            }
            return _ctxs.GetVFU().UpdateVersaoProjetosServices(_mapper.Map<VersaoProjetosDTOUpdateDTO>(VersaoProjetos), VersaoProjetos.Id);
        }
    }
}