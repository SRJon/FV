using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using back.data.entities.Book;
using back.data.http;
using back.domain.DTO.Book;
using back.domain.Repositories;
using back.infra.Data.Context;
using back.infra.Services.BookServices;
using back.MappingConfig;
using Microsoft.EntityFrameworkCore;

namespace back.infra.Data.Repositories
{
    public class BookRepository : ValidPagination, IBookRepository
    {
        private readonly IMapper _mapper;
        private readonly DbContexts _ctxs;

        public BookRepository(DbContexts ctxs) : base()
        {
            this._mapper = MapperConfig.MapperConfiguration().CreateMapper();
            _ctxs = ctxs;

        }

        public async Task<Response<List<BookDTO>>> GetAllPaginateAsync(int page, int limit)
        {
            var response = new Response<List<BookDTO>>();
            var contexto = _ctxs.GetVFU();
            try
            {
                base.ValidPaginate(page, limit);
                var savedSearches = contexto.Book.Skip(base.skip).OrderBy(o => o.Id).Take(base.limit);

                List<BookDTO> dTOs = new List<BookDTO>();

                var Books = await savedSearches.ToListAsync();
                Books.ForEach(e => dTOs.Add(_mapper.Map<BookDTO>(e)));

                response.Data = dTOs;
                response.TotalPages = await contexto.Book.CountAsync();
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

        public async Task<BookDTO> GetById(int id)
        {
            return _mapper.Map<BookDTO>(await this._ctxs.
            GetVFU()
            .GetByIdService(id));
        }

        public Task<bool> Create(Book Book)
        {
            try
            {
                return _ctxs.GetVFU().Create(Book);
            }
            catch (Exception e)
            {
                return BadRequest(new Response<string>
                {
                    Message = "Erro ao criar Book",
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
                    Message = "Erro ao deletar Book.",
                    Data = e.Message,
                    Success = false,
                    StatusCode = 400
                });
            }
        }

        public Task<bool> Update(Book Book)
        {
            if (Book.Id == 0)
            {
                return BadRequest(new Response<string>
                {
                    Message = "Id não informado",
                    Data = "",
                    Success = false,
                    StatusCode = 400
                });
            }
            return _ctxs.GetVFU().UpdateBookServices(_mapper.Map<BookDTOUpdateDTO>(Book), Book.Id);
        }
    }
}