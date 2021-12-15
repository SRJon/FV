using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using back.data.entities.SintegraCNPJQuery;
using back.domain.DTO.TSIBairroDTO;

namespace back.domain.Repositories
{
    public interface ITSIBAIRepository
    {
        public Task<TSIBAIDTO> GetById(int id);
        public Task<TSIBAIDTO> GetByNome(string nomeEnd);
        public TSIBAIDTO AtribuicaoValoresCliente(TSIBAIDTO endereco, SintegraCNPJ cnpj);
        public Task<bool> Create(TSIBAIDTOCreate tsibai);
    }
}