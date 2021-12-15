using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using back.data.http;
using back.domain.DTO.TGFCABNotaDTO;

namespace back.domain.Repositories
{
    public interface ITGFCABRepository
    {
        public Task<TGFCABDTO> GetById(int nuNota);
        public Task<Response<List<TGFCABDTO>>> GetAllPaginateAsync(int page, int limit, int codParc);

        public Task<TGFCABNuNotaDTO> GetByIdNF(int nuNota);
        public Task<Response<List<TGFCABNuNotaDTO>>> GetAllNFPaginateAsync(int page, int limit, int codParc);
    }
}