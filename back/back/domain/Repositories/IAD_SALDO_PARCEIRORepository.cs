using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using back.data.entities.View_AD_SALDO_PARCEIRO;
using back.domain.DTO.ViewAD_SALDO_PARCEIRODTO;

namespace back.domain.Repositories
{
    public interface IAD_SALDO_PARCEIRORepository
    {
        public Task<AD_SALDO_PARCEIRODTO> GetById(int codParc);
    }
}