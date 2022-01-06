using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using back.data.entities.View_AD_PEDIDOCANCELAMENTO;
using back.infra.Data.Context;
using Microsoft.EntityFrameworkCore;

namespace back.infra.Services.AD_PEDIDOCANCELAMENTOServices
{
    public static class AD_PEDIDOCANCELAMENTOGetByNuNota
    {
        public static Task<AD_PEDIDOCANCELAMENTO> GetByNuNotaService(this DbAppContextSankhya ctx, int numNota) => ctx.AD_PEDIDOCANCELAMENTO.FirstOrDefaultAsync(x => x.Ped_Nunota == numNota);
    }
}