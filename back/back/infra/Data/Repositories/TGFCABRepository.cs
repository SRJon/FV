using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using back.data.http;
using back.domain.DTO.TGFCABNotaDTO;
using back.domain.Repositories;
using back.infra.Data.Context;
using back.infra.Services.TGFCABServices;
using back.MappingConfig;
using Microsoft.EntityFrameworkCore;

namespace back.infra.Data.Repositories
{
    public class TGFCABRepository : ValidPagination, ITGFCABRepository
    {
        private readonly IMapper _mapper;
        private readonly DbContexts _ctxs;

        public TGFCABRepository(DbContexts ctxs) : base()
        {
            _mapper = MapperConfig.MapperConfiguration().CreateMapper();
            _ctxs = ctxs;
        }

        public async Task<Response<List<TGFCABNuNotaDTO>>> GetAllNFPaginateAsync(int page, int limit, int codParc)
        {
            var response = new Response<List<TGFCABNuNotaDTO>>();
            var contexto = _ctxs.GetSankhya();
            try
            {
                base.ValidPaginate(page, limit);
                var savedSearches = contexto.TGFCAB.Include(o => o.Empresa).Include(o => o.TGFTPV)
                                                   .Where(u => u.codparc == codParc && u.tipmov == "V" && u.statusnota == "L" && u.statusnfe == "A")
                                                   .OrderBy(o => o.numnota);

                List<TGFCABNuNotaDTO> dTOs = new List<TGFCABNuNotaDTO>();

                var notas = await savedSearches.Skip(base.skip).Take(limit).ToListAsync();
                notas.ForEach(e => dTOs.Add(_mapper.Map<TGFCABNuNotaDTO>(e)));

                response.Data = dTOs;
                response.TotalPages = await savedSearches.CountAsync();
                response.Page = page;
                response.TotalPages = base.getTotalPages(response.TotalPages);
                response.Success = true;
                response.StatusCode = 200;
                return response;

            }
            catch (System.Exception e)
            {

                response.StatusCode = 400;
                response.Message = e.Message;
                return response;
            }

        }

        public async Task<Response<List<TGFCABDTO>>> GetAllPaginateAsync(int codParc, int page, int limit)
        {
            var response = new Response<List<TGFCABDTO>>();
            var contexto = _ctxs.GetSankhya();
            try
            {
                base.ValidPaginate(page, limit);
                var savedSearches = contexto.TGFCAB.Where(u => u.codparc == codParc).Skip(base.skip).OrderBy(o => o.numnota).Take(base.limit);
                List<TGFCABDTO> dTOs = new List<TGFCABDTO>();

                var notas = await savedSearches.ToListAsync();
                notas.ForEach(e => dTOs.Add(_mapper.Map<TGFCABDTO>(e)));

                response.Data = dTOs;
                response.TotalPages = await contexto.TGFCAB.CountAsync();
                response.Page = page;
                response.TotalPages = base.getTotalPages(response.TotalPages);
                response.Success = true;
                response.StatusCode = 200;
                return response;

            }
            catch (System.Exception e)
            {

                response.StatusCode = 400;
                response.Message = e.Message;
                return response;
            }

        }

        public async Task<TGFCABDTO> GetById(int numNota)
        {
            var res = await this._ctxs.GetSankhya().GetByIdService(numNota);
            var rmapper = _mapper.Map<TGFCABDTO>(res);

            return rmapper;
        }

        public async Task<TGFCABNuNotaDTO> GetByIdNF(int numNota)
        {
            var res = await this._ctxs.GetSankhya().GetByIdServiceNF(numNota);

            var rmapper = _mapper.Map<TGFCABNuNotaDTO>(res);

            return rmapper;
        }
    }
}