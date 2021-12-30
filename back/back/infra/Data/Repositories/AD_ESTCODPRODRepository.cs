using AutoMapper;
using back.data.entities;
using back.data.http;
using back.domain.DTO.AD_Estoque;
using back.domain.Repositories;
using back.infra.Data.Context;
using back.MappingConfig;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace back.infra.Data.Repositories
{
    public class AD_ESTCODPRODRepository : ValidPagination, IAD_ESTCODPRODRepository
    {
        private readonly IMapper _mapper;
        private readonly DbContexts _ctxs;

        public AD_ESTCODPRODRepository(DbContexts ctxs) : base()
        {
            this._mapper = MapperConfig.MapperConfiguration().CreateMapper();
            _ctxs = ctxs;
        }

        // Métido auxiliar para verificar se a variável tipo string está nula ou vazia
        private static bool IsNullOrEmpty(string text)
        {
            return text == null || text == string.Empty;            
        }

        /*
         * Método para filtrar os resgistros com todos os campos informados na tela como a paginação
         */
        public async Task<Response<List<AD_ESTCODPRODDTO>>> GetSearchPaginateAsync(int page, int limit, int Produto, int CodGrupoProd, string DescrProd, string ComplDesc)
        {
            var response = new Response<List<AD_ESTCODPRODDTO>>();
            var contexto = _ctxs.GetSankhya();
            try
            {
                base.ValidPaginate(page, limit);
                var savedSearches = contexto.AD_ESTCODPROD.Skip(base.skip);
                
                if (Produto != -1)
                {
                    savedSearches = savedSearches.Where(x => x.PRODUTO == Produto);
                }
                if(CodGrupoProd != -1) savedSearches = savedSearches.Where(x => x.CODGRUPOPROD == CodGrupoProd);
                if(!IsNullOrEmpty(DescrProd)) savedSearches = savedSearches.Where(x => x.DESCRPROD.Contains(DescrProd));
                if (!IsNullOrEmpty(ComplDesc)) savedSearches = savedSearches.Where(x => x.COMPLDESC.Contains(ComplDesc));

                List<AD_ESTCODPRODDTO> dTOs = new List<AD_ESTCODPRODDTO>();

                var parceiros = await savedSearches.OrderBy(e=>e.PRODUTO).Take(this.limit).ToListAsync();
                parceiros.ForEach(e => dTOs.Add(_mapper.Map<AD_ESTCODPRODDTO>(e)));


                response.Data = dTOs;
                response.TotalPages = await savedSearches.CountAsync();
                response.Page = page;
                response.TotalPages = (response.TotalPages / base.limit) + 1;
                response.TotalPages = response.TotalPages == 0 ? 0 : response.TotalPages;
                response.Success = true;
                response.StatusCode = 200;
                return response;

            }
            catch (System.Exception e)
            {

                response.StatusCode = 400;
                response.Message = e.Message;
                return response;
            }
        }
      
    }
}
