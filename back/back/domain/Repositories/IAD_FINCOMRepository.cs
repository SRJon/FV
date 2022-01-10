using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using back.data.http;
using back.domain.DTO.ViewAD_FINCOMDTO;

namespace back.domain.Repositories
{
    public interface IAD_FINCOMRepository
    {
        public Task<Response<List<AD_FINCOMDTO>>> GetAllPaginateAsync(int page, int limit, int codVendedor);
        public Task<AD_FINCOMDTO> GetById(int nuFin);
    }
}