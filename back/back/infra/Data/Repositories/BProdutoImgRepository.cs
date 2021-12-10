using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using back.data.entities.BProdutoImg;
using back.data.http;
using back.domain.DTO.BProdutoImg;
using back.domain.Repositories;
using back.infra.Data.Context;
using back.infra.Services.BProdutoImgServices;
using back.MappingConfig;
using Microsoft.EntityFrameworkCore;

namespace back.infra.Data.Repositories
{
    public class BProdutoImgRepository : ValidPagination, IBProdutoImgRepository
    {
        private readonly IMapper _mapper;
        private readonly DbContexts _ctxs;

        public BProdutoImgRepository(DbContexts ctxs) : base()
        {
            this._mapper = MapperConfig.MapperConfiguration().CreateMapper();
            _ctxs = ctxs;

        }

        public async Task<Response<List<BProdutoImgDTO>>> GetAllPaginateAsync(int page, int limit)
        {
            var response = new Response<List<BProdutoImgDTO>>();
            var contexto = _ctxs.GetVFU();
            try
            {
                base.ValidPaginate(page, limit);
                var savedSearches = contexto.BProdutoImg.Skip(base.skip).OrderBy(o => o.Id).Take(base.limit);

                List<BProdutoImgDTO> dTOs = new List<BProdutoImgDTO>();

                var BProdutoImgs = await savedSearches.ToListAsync();
                BProdutoImgs.ForEach(e => dTOs.Add(_mapper.Map<BProdutoImgDTO>(e)));

                response.Data = dTOs;
                response.TotalPages = await contexto.BProdutoImg.CountAsync();
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

        public async Task<BProdutoImgDTO> GetById(int id)
        {
            return _mapper.Map<BProdutoImgDTO>(await this._ctxs.
            GetVFU()
            .GetByIdService(id));
        }

        public Task<bool> Create(BProdutoImg BProdutoImg)
        {
            try
            {
                return _ctxs.GetVFU().Create(BProdutoImg);
            }
            catch (Exception e)
            {
                return BadRequest(new Response<string>
                {
                    Message = "Erro ao criar BProdutoImg",
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
                    Message = "Erro ao deletar BProdutoImg.",
                    Data = e.Message,
                    Success = false,
                    StatusCode = 400
                });
            }
        }

        public Task<bool> Update(BProdutoImg BProdutoImg)
        {
            if (BProdutoImg.Id == 0)
            {
                return BadRequest(new Response<string>
                {
                    Message = "Id não informado",
                    Data = "",
                    Success = false,
                    StatusCode = 400
                });
            }
            return _ctxs.GetVFU().UpdateBProdutoImgServices(_mapper.Map<BProdutoImgDTOUpdateDTO>(BProdutoImg), BProdutoImg.Id);
        }
    }
}