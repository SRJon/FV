using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using back.data.entities.Screen;
using back.data.http;
using back.domain.Repositories;
using back.infra.Data.Context;
using Microsoft.EntityFrameworkCore;
using back.infra.Services.TelaServices;
using back.domain.DTO.ScreenDTO;
using AutoMapper;
using back.MappingConfig;

namespace back.infra.Data.Repositories
{
    public class TelaRepository : ValidPagination, ITelaRepository
    {
        private readonly IMapper _mapper;
        private readonly DbContexts _ctxs;


        public TelaRepository(DbContexts ctxs) : base()
        {
            this._mapper = MapperConfig.MapperConfiguration().CreateMapper();
            _ctxs = ctxs;


        }

        public Task<bool> Create(Tela tela)
        {
            try
            {
                return _ctxs.GetVFU().Create(tela);
            }
            catch (Exception e)
            {
                return BadRequest(new Response<string>
                {
                    Message = "Erro ao criar tela",
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
                    Message = "Erro ao deletar tela",
                    Data = e.Message,
                    Success = false,
                    StatusCode = 400
                });
            }
        }

        public async Task<Response<List<TelaDTO>>> GetAllPaginateAsync(int page, int limit)
        {
            var response = new Response<List<TelaDTO>>();
            var contexto = _ctxs.GetVFU();
            try
            {
                base.ValidPaginate(page, limit);
                var savedSearches = contexto.Tela.Skip(base.skip).OrderBy(o => o.Id).Take(base.limit);//.Include(x => x.Parameters);

                List<TelaDTO> dTOs = new List<TelaDTO>();

                var telas = await savedSearches.ToListAsync();
                telas.ForEach(e => dTOs.Add(_mapper.Map<TelaDTO>(e)));

                response.Data = dTOs;
                response.TotalPages = await contexto.Tela.CountAsync();
                response.Page = page;
                response.TotalPages = (response.TotalPages / base.limit) + 1;
                response.TotalPages = response.TotalPages == 0 ? 0 : response.TotalPages;
                response.Success = true;
                response.StatusCode = 200;
                return response;
            }
            catch (System.Exception e)
            {
                throw e;
            }
        }

        public async Task<TelaDTO> GetById(int id)
        {
            var b = _mapper.Map<TelaDTO>(await this._ctxs
            .GetVFU()
            .GetByIdService(id));
            if (b.TelaId != null)
            {
                b.tela = _mapper.Map<TelaDTOChild>(await this._ctxs.GetVFU().GetByIdService(b.TelaId.Value));
            }
            return b;
        }



        public Task<bool> Update(Tela tela)
        {
            if (tela.Id == 0)
            {
                return BadRequest(new Response<string>
                {
                    Message = "Id não informado",
                    Data = "",
                    Success = false,
                    StatusCode = 400
                });
            }
            return _ctxs.GetVFU().UpdateScreenServices(_mapper.Map<TelaDTOUpdateDTO>(tela), tela.Id);
        }
        public bool ProductExists(int id) => _ctxs.GetVFU().Tela.Any(e => e.Id == id);

        public TelaDTO GetByIdAsync(int id)
        {
            var response = new Response<Tela>();
            try
            {
                return _mapper.Map<TelaDTO>(this._ctxs
            .GetVFU()
            .GetByIdAsyncService(id));
            }
            catch (Exception e)
            {
                System.Console.WriteLine(e);
                return null;
            }

        }

        public Task<List<Tela>> GetAll(int page, int limit)
        {
            throw new NotImplementedException();
        }
    }
}