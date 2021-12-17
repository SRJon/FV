using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using back.data.http;
using back.domain.DTO.View_AD_DEVSOLICITACAODTO;

namespace back.domain.Repositories
{
    public interface IAD_DEVSOLICITACAORepository
    {
        public Task<AD_DEVSOLICITACAODTODevolucao> GetDevolucaoByNuSoldev(int nuSoldev);
        public Task<Response<List<AD_DEVSOLICITACAODTODevolucao>>> GetAllDevolucaoPaginateAsync(int page, int limit, int codParc);
    }
}