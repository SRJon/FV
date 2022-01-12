using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using back.data.entities.AD_SOLCANota;
using back.data.http;
using back.domain.DTO.AD_SOLCAN;
using back.domain.DTO.AD_STATUS;

namespace back.domain.Repositories
{
    public interface IAD_SOLCANRepository
    {
        public Task<Response<List<AD_SOLCANDTO>>> GetAllPaginateAsync(int codVend, int page, int limit);
        public Task<AD_SOLCANDTO> GetByNuNota(int NuNota);
        public bool ValidCancelRequest(string reason);
        public Task<bool> CancelRequistExistsAsync(int NuNota);
        public Task<bool> CreateSolcan(AD_SOLCANCreateDTO solcanCreate);
    }
}