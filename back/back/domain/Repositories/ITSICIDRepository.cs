using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using back.data.entities.SintegraCNPJQuery;
using back.domain.DTO.TSICidadeDTO;

namespace back.domain.Repositories
{
    public interface ITSICIDRepository
    {
        public Task<TSICIDDTO> GetById(int id);
        public Task<TSICIDDTO> GetByNome(string nomeCid);
        public TSICIDDTO AtribuicaoValoresCliente(TSICIDDTO endereco, SintegraCNPJ cnpj);
        public Task<bool> Create(TSICIDDTOCreate tsicid);
    }
}