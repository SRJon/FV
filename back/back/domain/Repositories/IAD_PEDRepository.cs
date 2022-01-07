using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using back.data.entities.View_AD_PED;
using back.data.http;
using back.domain.DTO.View_AD_PEDDTO;

namespace back.domain.Repositories
{
    public interface IAD_PEDRepository
    {
        public Task<AD_PEDDTO> GetByNumNota(int numNota);
        public Task<AD_PEDDTO> GetByNomeParc(string nomeParc);
        public Task<AD_PEDDTO> GetByValor(double valor);
        public Task<AD_PEDDTO> GetBySituacao(string status);
        public Task<AD_PEDDTO> GetByPedidoId(int pedidoId);
        public Task<AD_PEDDTO> GetByNuNota(int nuNota);
        public Task<Response<List<AD_PEDPedidoDTO>>> GetAllPaginateAsync(short codVend, string pesquisa, int page, int limit);
    }
}