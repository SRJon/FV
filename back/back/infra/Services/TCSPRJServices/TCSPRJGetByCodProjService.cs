using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using back.data.entities.TCSProjeto;
using back.infra.Data.Context;
using Microsoft.EntityFrameworkCore;

namespace back.infra.Services.TCSPRJServices
{
    public static class TCSPRJGetByCodProjService
    {
        public static Task<TCSPRJ> GetByIdService(this DbAppContextSankhya ctx, int codProj)
        {
            var result = ctx.TCSPRJ.FirstOrDefaultAsync(x => x.Codproj == codProj);
            return result;
        }
    }
}