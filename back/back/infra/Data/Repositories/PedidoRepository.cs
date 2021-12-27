using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using back.data.entities.Request;
using back.data.http;
using back.domain.DTO.Request;
using back.domain.DTO.TGFParceiroDTO;
using back.domain.DTO.TGFTPVendaDTO;
using back.domain.Repositories;
using back.infra.Data.Context;
using back.infra.Services.PedidoServices;
using back.MappingConfig;
using Microsoft.EntityFrameworkCore;

namespace back.infra.Data.Repositories
{
    public class PedidoRepository : ValidPagination, IPedidoRepository
    {
        private readonly IMapper _mapper;
        private readonly DbContexts _ctxs;
        private readonly ITGFTPVRepository _ITITGFTPVRepository;
        private readonly ITCSPRJRepository _ITCSPRJRepository;
        private readonly ITGFPARRepository _ITGFPARRepository;

        public PedidoRepository(DbContexts ctxs, ITGFTPVRepository ITGFTPVRepository, ITCSPRJRepository ITCSPRJRepository, ITGFPARRepository ITGFPARRepository) : base()
        {
            this._mapper = MapperConfig.MapperConfiguration().CreateMapper();
            _ctxs = ctxs;
            _ITITGFTPVRepository = ITGFTPVRepository;
            _ITCSPRJRepository = ITCSPRJRepository;
            _ITGFPARRepository = ITGFPARRepository;

        }

        public async Task<Response<List<PedidoDTO>>> GetAllPaginateAsync(int page, int limit)
        {
            var response = new Response<List<PedidoDTO>>();
            var contexto = _ctxs.GetVFU();
            try
            {
                base.ValidPaginate(page, limit);
                var savedSearches = contexto.Pedido.Include(u => u.Usuario).Include(e => e.Empresa).Include(p => p.PedidoItem).Skip(base.skip).OrderBy(o => o.Id).Take(base.limit);

                List<PedidoDTO> dTOs = new List<PedidoDTO>();

                var Pedidos = await savedSearches.ToListAsync();
                Pedidos.ForEach(e => dTOs.Add(_mapper.Map<PedidoDTO>(e)));
                foreach (var dto in dTOs)
                {
                    try
                    {
                        dto.TGFTPV = await _ITITGFTPVRepository.GetByCODTIPVENDA((int)dto.CondPagCodTipVenda, (DateTime)dto.CondPagDhAlter);
                    }
                    catch (System.Exception)
                    {
                        dto.TGFTPV = null;
                    }
                    try
                    {
                        dto.TCSPRJ = await _ITCSPRJRepository.GetByCODTIPVENDA((int)dto.ProjetoCod);
                    }
                    catch (System.Exception)
                    {
                        dto.TCSPRJ = null;
                    }
                    try
                    {
                        dto.TGFPAR = _mapper.Map<TGFPARDTOPedido>(await _ITGFPARRepository.GetById((int)dto.ClienteRemCod));
                    }
                    catch (System.Exception)
                    {
                        dto.TGFPAR = null;
                    }
                }
                response.Data = dTOs;
                response.TotalPages = await contexto.Pedido.CountAsync();
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
        public async Task<Response<List<PedidoDTO>>> GetAllPaginateAsyncByParc(int codParc, int page, int limit)
        {
            var response = new Response<List<PedidoDTO>>();
            var contexto = _ctxs.GetVFU();
            try
            {
                base.ValidPaginate(page, limit);
                var savedSearches = contexto.Pedido.Include(u => u.Usuario).Include(e => e.Empresa).Include(p => p.PedidoItem).Where(u => u.ClienteCod == codParc).Skip(base.skip).OrderBy(o => o.Id).Take(base.limit);

                List<PedidoDTO> dTOs = new List<PedidoDTO>();

                var Pedidos = await savedSearches.ToListAsync();
                Pedidos.ForEach(e => dTOs.Add(_mapper.Map<PedidoDTO>(e)));
                foreach (var dto in dTOs)
                {
                    try
                    {
                        dto.TGFTPV = await _ITITGFTPVRepository.GetByCODTIPVENDA((int)dto.CondPagCodTipVenda, (DateTime)dto.CondPagDhAlter);
                    }
                    catch (System.Exception)
                    {
                        dto.TGFTPV = null;
                    }
                    try
                    {
                        dto.TCSPRJ = await _ITCSPRJRepository.GetByCODTIPVENDA((int)dto.ProjetoCod);
                    }
                    catch (System.Exception)
                    {
                        dto.TCSPRJ = null;
                    }
                    try
                    {
                        dto.TGFPAR = _mapper.Map<TGFPARDTOPedido>(await _ITGFPARRepository.GetById((int)dto.ClienteCod));
                    }
                    catch (System.Exception)
                    {
                        dto.TGFPAR = null;
                    }
                }
                response.Data = dTOs;
                response.TotalPages = await contexto.Pedido.CountAsync();
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

        public async Task<PedidoDTO> GetById(int id)
        {
            var result = _mapper.Map<PedidoDTO>(await this._ctxs.
            GetVFU()
            .GetByIdService(id));

            try
            {
                result.TGFTPV = await _ITITGFTPVRepository.GetByCODTIPVENDA((int)result.CondPagCodTipVenda, (DateTime)result.CondPagDhAlter);
            }
            catch (System.Exception)
            {
                result.TGFTPV = null;
            }
            try
            {
                result.TCSPRJ = await _ITCSPRJRepository.GetByCODTIPVENDA((int)result.ProjetoCod);
            }
            catch (System.Exception)
            {
                result.TCSPRJ = null;
            }
            try
            {
                result.TGFPAR = _mapper.Map<TGFPARDTOPedido>(await _ITGFPARRepository.GetById((int)result.ClienteRemCod));
            }
            catch (System.Exception)
            {
                result.TGFPAR = null;
            }
            return result;
        }

        public Task<bool> Create(Pedido Pedido)
        {
            try
            {
                return _ctxs.GetVFU().Create(Pedido);
            }
            catch (Exception e)
            {
                return BadRequest(new Response<string>
                {
                    Message = "Erro ao criar Pedido",
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
                    Message = "Erro ao deletar Pedido.",
                    Data = e.Message,
                    Success = false,
                    StatusCode = 400
                });
            }
        }

        public Task<bool> Update(Pedido Pedido)
        {
            if (Pedido.Id == 0)
            {
                return BadRequest(new Response<string>
                {
                    Message = "Id não informado",
                    Data = "",
                    Success = false,
                    StatusCode = 400
                });
            }
            return _ctxs.GetVFU().UpdatePedidoServices(_mapper.Map<PedidoDTOUpdateDTO>(Pedido), Pedido.Id);
        }
    }
}