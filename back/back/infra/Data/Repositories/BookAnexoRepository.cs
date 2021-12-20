using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using back.data.entities.BookAnexoAmostra;
using back.data.http;
using back.domain.DTO.BookAnexo;
using back.domain.DTO.TGFProdutoDTO;
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
        private readonly ITGFPRORepository _TGFPRORepository;

        public BookAnexoRepository(DbContexts ctxs, ITGFPRORepository TGFPRORepository) : base()
        {
            this._mapper = MapperConfig.MapperConfiguration().CreateMapper();
            _ctxs = ctxs;
            _TGFPRORepository = TGFPRORepository;

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

        public async Task<Response<List<BookAnexoAmostraDTO>>> GetAllBookAmostra(int page, int limit)
        {
            var response = new Response<List<BookAnexoAmostraDTO>>();
            var contexto = _ctxs.GetVFU();
            try
            {
                base.ValidPaginate(page, limit);
                var savedSearches = contexto.BookAnexo.Include(u => u.book).Skip(base.skip).OrderBy(o => o.Id).Take(base.limit);

                List<BookAnexoAmostraDTO> dTOs = new List<BookAnexoAmostraDTO>();

                var BookAnexos = await savedSearches.ToListAsync();
                BookAnexos.ForEach(e => dTOs.Add(_mapper.Map<BookAnexoAmostraDTO>(e)));
                foreach (var bookAnexo in dTOs)
                {
                    bookAnexo.TGFPRO = _mapper.Map<TGFPROAmostraDTO>(await _TGFPRORepository.GetByCodProd((int)bookAnexo.CodProd));
                }

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

        public async Task<BookAnexoAmostraDTO> GetBycodProdBookAmostra(int codProd)
        {
            var rmapper = _mapper.Map<BookAnexoAmostraDTO>(await this._ctxs.
            GetVFU()
            .GetBycodProdService(codProd));
            try
            {
                rmapper.TGFPRO = _mapper.Map<TGFPROAmostraDTO>(await _TGFPRORepository.GetByCodProd(codProd));
            }
            catch (System.Exception)
            {

                throw;
            }
            return rmapper;
        }
    }
}