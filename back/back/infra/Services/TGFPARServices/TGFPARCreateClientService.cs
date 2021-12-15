using System.Threading.Tasks;
using AutoMapper;
using back.data.entities.TGFContato;
using back.domain.DTO.TGFParceiroDTO;
using back.infra.Data.Context;
using back.infra.Data.Utils;
using back.MappingConfig;

namespace back.infra.Services.TGFPARServices
{
    public static class TGFPARCreateClientService
    {
        private static readonly IMapper _mapper = MapperConfig.MapperConfiguration().CreateMapper();
        public static async Task<bool> Create(this DbAppContextSankhya ctx, TGFPARDTOCreate cliente)
        {
            var json = cliente.ProductEntityToJson("Parceiro");

            var result = await APISankhya.SankhyaCRUDPostAsync(json);
            var resposta = result.Substring(result.IndexOf(":", 22) + 2, 1);

            return resposta == "1" ? (true) : (false);
        }
    }
}