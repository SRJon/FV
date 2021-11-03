using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using back.data.entities.Screen;
using back.data.http;
using back.domain.Repositories;
using back.infra.Data.Context;
using Microsoft.EntityFrameworkCore;

namespace back.infra.Data.Repositories
{
    public class TelaRepository : ValidPagination, ITelaRepository
    {
        private readonly DbContexts _ctxs;


        public TelaRepository(DbContexts ctxs) : base()
        {
            _ctxs = ctxs;

        }

        public Task<bool> Create(Tela usuario)
        {
            throw new System.NotImplementedException();
        }

        public Task<bool> Delete(int id)
        {
            throw new System.NotImplementedException();
        }

        public async Task<Response<List<Tela>>> GetAllPaginateAsync(int page, int limit)
        {
            var response = new Response<List<Tela>>();
            var GRUPOLITORAL = _ctxs.GetGrupoLitoral();
            try
            {
                base.ValidPaginate(page, limit);
                var savedSearches = GRUPOLITORAL.Tela.Skip(base.skip).OrderBy(o => o.TelaId).Take(base.limit);//.Include(x => x.Parameters);



                response.Data = await savedSearches.ToListAsync();
                response.TotalPages = await GRUPOLITORAL.Usuario.CountAsync();
                response.Page = page;
                response.TotalPages = (response.TotalPages / base.limit) + 1;
                response.TotalPages = response.TotalPages == 0 ? 0 : response.TotalPages;
                response.Success = true;
                response.StatusCode = 200;
                return response;
            }
            catch (System.Exception)
            {
                response.Data = null;
                response.StatusCode = 400;
                return response;
            }
        }

        public Task<Tela> GetById(int id)
        {
            throw new System.NotImplementedException();
        }



        public Task<bool> Update(Tela usuario)
        {
            throw new System.NotImplementedException();
        }
        public bool ProductExists(int id) => _ctxs.GetGrupoLitoral().Usuario.Any(e => e.UsuarioId == id);

        public Tela GetByIdAsync(int id)
        {
            var response = new Response<Tela>();
            try
            {
                var savedSearches = _ctxs.GetGrupoLitoral().Tela.FirstOrDefaultAsync(x => x.TelaId == id);



                return savedSearches.Result;
            }
            catch (Exception e)
            {
                System.Console.WriteLine(e);

                return null;
            }

        }

        public Task<List<Tela>> GetAll(int page, int limit)
        {
            throw new NotImplementedException();
        }
    }
}