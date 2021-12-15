using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using back.data.entities.TGFTPVenda;
using back.domain.DTO.TGFTPVendaDTO;
using back.infra.Data.Context;
using Microsoft.EntityFrameworkCore;

namespace back.infra.Services.TGFTPVServices
{
    public static class TGFTPVGetByCodTipVendaService
    {
        public static Task<TGFTPV> GetByIdService(this DbAppContextSankhya ctx, int codTipVenda, DateTime dhAlter)
        {
            var result = ctx.TGFTPV.FirstOrDefaultAsync(x => x.Codtipvenda == codTipVenda && x.Dhalter == dhAlter);
            return result;
        }
    }
}