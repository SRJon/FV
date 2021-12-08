using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using back.data.entities.View_AD_SALDO_PARCEIRO;
using back.infra.Data.Context;
using Microsoft.EntityFrameworkCore;

namespace back.infra.Services.AD_SALDO_PARCEIROServices
{
    public static class AD_SALDO_PARCEIROGetByIdService
    {
        public static Task<AD_SALDO_PARCEIRO> GetByIdService(this DbAppContextSankhya ctx, int id) => ctx.AD_SALDO_PARCEIRO.FirstOrDefaultAsync(x => x.CodParc == id);
    }
}