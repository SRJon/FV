using System.Threading.Tasks;
using back.domain.DTO.TGFParceiroDTO;
using back.infra.Data.Context;

namespace back.infra.Services.TGFPARServices
{
    public static class TGFPARCreateClientService
    {
        public static Task<bool> Create(this DbAppContextSankhya ctx, TGFPARDTOCreate cliente)
        {
            return null;
        }
    }
}