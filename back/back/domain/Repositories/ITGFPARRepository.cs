using System.Collections.Generic;
using System.Threading.Tasks;
using back.data.entities.SintegraCNPJQuery;
using back.data.http;
using back.domain.DTO.TGFParceiroDTO;

namespace back.domain.Repositories
{
    public interface ITGFPARRepository
    {
        public Task<TGFPARDTO> GetById(int id);
        public int GetLastIdCreated();
        public Task<Response<List<TGFPARDTO>>> GetAllPaginateAsync(int page, int limit);
        public Task<TGFPARDTO> GetByCgc_cpf(string cgc_cpf);
        public Task<bool> Create(TGFPARDTOCreate cliente);
        public TGFPARDTO AtribuicaoValoresCliente(TGFPARDTO cliente, SintegraCNPJ cnpj);

    }
}