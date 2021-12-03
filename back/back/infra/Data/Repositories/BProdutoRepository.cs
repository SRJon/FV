using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using back.data.entities.BProduto;
using back.data.http;
using back.domain.DTO.BProduto;
using back.domain.Repositories;
using back.infra.Data.Context;
using back.infra.Services.BProdutoServices;
using back.MappingConfig;
using Microsoft.EntityFrameworkCore;

namespace back.infra.Data.Repositories
{
    public class BProdutoRepository : ValidPagination, IBProdutoRepository
    {
        private readonly IMapper _mapper;
        private readonly DbContexts _ctxs;

        public BProdutoRepository(DbContexts ctxs) : base()
        {
            this._mapper = MapperConfig.MapperConfiguration().CreateMapper();
            _ctxs = ctxs;

        }

        public async Task<Response<List<BProdutoDTO>>> GetAllPaginateAsync(int page, int limit)
        {
            var response = new Response<List<BProdutoDTO>>();
            var contexto = _ctxs.GetVFU();
            try
            {
                base.ValidPaginate(page, limit);
                var savedSearches = contexto.BProduto.Skip(base.skip).OrderBy(o => o.Id).Take(base.limit);

                List<BProdutoDTO> dTOs = new List<BProdutoDTO>();

                var BProdutos = await savedSearches.ToListAsync();
                BProdutos.ForEach(e => dTOs.Add(_mapper.Map<BProdutoDTO>(e)));

                response.Data = dTOs;
                response.TotalPages = await contexto.BProduto.CountAsync();
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

        public async Task<BProdutoDTO> GetById(int id)
        {
            return _mapper.Map<BProdutoDTO>(await this._ctxs.
            GetVFU()
            .GetByIdService(id));
        }

        public Task<bool> Create(BProduto BProduto)
        {
            try
            {
                return _ctxs.GetVFU().Create(BProduto);
            }
            catch (Exception e)
            {
                return BadRequest(new Response<string>
                {
                    Message = "Erro ao criar BProduto",
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
                    Message = "Erro ao deletar BProduto.",
                    Data = e.Message,
                    Success = false,
                    StatusCode = 400
                });
            }
        }

        public Task<bool> Update(BProduto BProduto)
        {
            if (BProduto.Id == 0)
            {
                return BadRequest(new Response<string>
                {
                    Message = "Id não informado",
                    Data = "",
                    Success = false,
                    StatusCode = 400
                });
            }
            return _ctxs.GetVFU().UpdateBProdutoServices(_mapper.Map<BProdutoDTOUpdateDTO>(BProduto), BProduto.Id);
        }
    }
}