using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using back.data.entities.TGFContato;
using back.domain.DTO.TGFContatoDTO;

namespace back.domain.Repositories
{
    public interface ITGFCTTRepository
    {
        public Task<TGFCTTDTO> GetById(int codParc, int codContato);
        public Task<bool> Create(TGFCTTDTOCreate cliente);
        public int GetLastIdCreated(int codParc);
    }
}