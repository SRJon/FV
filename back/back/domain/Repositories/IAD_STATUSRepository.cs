using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using back.data.http;
using back.domain.DTO.AD_STATUS;

namespace back.domain.Repositories
{
    public interface IAD_STATUSRepository
    {
        public Task<Response<List<AD_STATUSDTO>>> GetAllPaginateAsync(int page, int limit);
        public Task<AD_STATUSDTO> GetByNuNota(int NuNota);
        public Task<bool> GetFaturado(int NuNota);
    }
}