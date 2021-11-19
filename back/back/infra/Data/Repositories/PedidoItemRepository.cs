using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using back.data.entities.PedidoItem;
using back.data.http;
using back.domain.DTO.PedidoItem;
using back.domain.Repositories;
using back.infra.Data.Context;
using back.infra.Services.PedidoItemServices;
using back.MappingConfig;
using Microsoft.EntityFrameworkCore;

namespace back.infra.Data.Repositories
{
    public class PedidoItemRepository : ValidPagination, IPedidoItemRepository
    {
        private readonly IMapper _mapper;
        private readonly DbContexts _ctxs;

        public PedidoItemRepository(DbContexts ctxs) : base()
        {
            this._mapper = MapperConfig.MapperConfiguration().CreateMapper();
            _ctxs = ctxs;

        }

        public async Task<Response<List<PedidoItemDTO>>> GetAllPaginateAsync(int page, int limit)
        {
            var response = new Response<List<PedidoItemDTO>>();
            var contexto = _ctxs.GetVFU();
            try
            {
                base.ValidPaginate(page, limit);
                var savedSearches = contexto.PedidoItem.Skip(base.skip).OrderBy(o => o.Id).Take(base.limit);

                List<PedidoItemDTO> dTOs = new List<PedidoItemDTO>();

                var PedidoItems = await savedSearches.ToListAsync();
                PedidoItems.ForEach(e => dTOs.Add(_mapper.Map<PedidoItemDTO>(e)));

                response.Data = dTOs;
                response.TotalPages = await contexto.PedidoItem.CountAsync();
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

        public async Task<PedidoItemDTO> GetById(int id)
        {
            return _mapper.Map<PedidoItemDTO>(await this._ctxs.
            GetVFU()
            .GetByIdService(id));
        }

        public Task<bool> Create(PedidoItem PedidoItem)
        {
            try
            {
                return _ctxs.GetVFU().Create(PedidoItem);
            }
            catch (Exception e)
            {
                return BadRequest(new Response<string>
                {
                    Message = "Erro ao criar PedidoItem",
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
                    Message = "Erro ao deletar PedidoItem.",
                    Data = e.Message,
                    Success = false,
                    StatusCode = 400
                });
            }
        }

        public Task<bool> Update(PedidoItem PedidoItem)
        {
            if (PedidoItem.Id == 0)
            {
                return BadRequest(new Response<string>
                {
                    Message = "Id não informado",
                    Data = "",
                    Success = false,
                    StatusCode = 400
                });
            }
            return _ctxs.GetVFU().UpdatePedidoItemServices(_mapper.Map<PedidoItemDTOUpdateDTO>(PedidoItem), PedidoItem.Id);
        }
    }
}