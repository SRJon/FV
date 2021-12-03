using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using back.data.entities.BookAnexo;
using back.data.http;
using back.domain.DTO.BookAnexo;
using back.domain.Repositories;
using back.infra.Data.Context;
using back.infra.Services.BookAnexoServices;
using back.MappingConfig;
using Microsoft.EntityFrameworkCore;

namespace back.infra.Data.Repositories
{
    public class BookAnexoRepository : ValidPagination, IBookAnexoRepository
    {
        private readonly IMapper _mapper;
        private readonly DbContexts _ctxs;

        public BookAnexoRepository(DbContexts ctxs) : base()
        {
            this._mapper = MapperConfig.MapperConfiguration().CreateMapper();
            _ctxs = ctxs;

        }

        public async Task<Response<List<BookAnexoDTO>>> GetAllPaginateAsync(int page, int limit)
        {
            var response = new Response<List<BookAnexoDTO>>();
            var contexto = _ctxs.GetVFU();
            try
            {
                base.ValidPaginate(page, limit);
                var savedSearches = contexto.BookAnexo.Skip(base.skip).OrderBy(o => o.Id).Take(base.limit);

                List<BookAnexoDTO> dTOs = new List<BookAnexoDTO>();

                var BookAnexos = await savedSearches.ToListAsync();
                BookAnexos.ForEach(e => dTOs.Add(_mapper.Map<BookAnexoDTO>(e)));

                response.Data = dTOs;
                response.TotalPages = await contexto.BookAnexo.CountAsync();
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

        public async Task<BookAnexoDTO> GetById(int id)
        {
            return _mapper.Map<BookAnexoDTO>(await this._ctxs.
            GetVFU()
            .GetByIdService(id));
        }

        public Task<bool> Create(BookAnexo BookAnexo)
        {
            try
            {
                return _ctxs.GetVFU().Create(BookAnexo);
            }
            catch (Exception e)
            {
                return BadRequest(new Response<string>
                {
                    Message = "Erro ao criar BookAnexo",
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
                    Message = "Erro ao deletar BookAnexo.",
                    Data = e.Message,
                    Success = false,
                    StatusCode = 400
                });
            }
        }

        public Task<bool> Update(BookAnexo BookAnexo)
        {
            if (BookAnexo.Id == 0)
            {
                return BadRequest(new Response<string>
                {
                    Message = "Id não informado",
                    Data = "",
                    Success = false,
                    StatusCode = 400
                });
            }
            return _ctxs.GetVFU().UpdateBookAnexoServices(_mapper.Map<BookAnexoDTOUpdateDTO>(BookAnexo), BookAnexo.Id);
        }
    }
}