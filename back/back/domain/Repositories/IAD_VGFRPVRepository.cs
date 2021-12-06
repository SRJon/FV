using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using back.data.entities.VIEW_AD_VGFRPV;
using back.domain.DTO.AD_VGFRPVDTO;

namespace back.domain.Repositories
{
    public interface IAD_VGFRPVRepository
    {
        public Task<data.http.Response<List<AD_VGFRPVSaldoDTO>>> GetAllPaginateAsync(int page, int limit, int codVendedor);
        public Task<AD_VGFRPVDTO> GetById(Int16 codVend);
    }
}