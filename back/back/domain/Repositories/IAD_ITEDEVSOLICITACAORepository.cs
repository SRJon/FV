using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using back.data.http;
using back.domain.DTO.AD_ItemDEVSOLICITACAO;

namespace back.domain.Repositories
{
    public interface IAD_ITEDEVSOLICITACAORepository
    {
        public Task<AD_ITEDEVSOLICITACAODTO> GetDevolucaoByNuSoldev(int nuSoldev);
        public Task<List<AD_ITEDEVSOLICITACAODTO>> GetAllIteDevolucaoSac(int nuSolDev);
    }
}