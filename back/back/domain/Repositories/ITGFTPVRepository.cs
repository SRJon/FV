using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using back.data.entities.TGFTPVenda;
using back.domain.DTO.TGFTPVendaDTO;

namespace back.domain.Repositories
{
    public interface ITGFTPVRepository
    {
        public Task<TGFTPVDTO> GetByCODTIPVENDA(int CODTIPVENDA, DateTime DHALTER);
    }
}