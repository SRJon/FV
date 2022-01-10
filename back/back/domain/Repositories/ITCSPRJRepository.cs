using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using back.domain.DTO.TCSProjetoDTO;
using back.domain.entities;

namespace back.domain.Repositories
{
    public interface ITCSPRJRepository
    {
        public Task<TCSPRJDTO> GetByCODTIPVENDA(int Codproj);
    }
}