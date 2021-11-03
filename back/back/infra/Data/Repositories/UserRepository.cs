using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using back.data.entities.Login;
using back.data.entities.User;
using back.data.http;
using back.domain.Repositories;
using back.infra.Data.Context;
using Microsoft.EntityFrameworkCore;

namespace back.infra.Data.Repositories
{
    public class UserRepository : ValidPagination, IUserRepository
    {
        private readonly DbContexts _ctxs;


        public UserRepository(DbContexts ctxs) : base()
        {
            _ctxs = ctxs;

        }

        public Task<bool> Create(Usuario usuario)
        {
            throw new System.NotImplementedException();
        }

        public Task<bool> Delete(int id)
        {
            throw new System.NotImplementedException();
        }

        public async Task<Response<List<Usuario>>> GetAllPaginateAsync(int page, int limit)
        {
            var response = new Response<List<Usuario>>();
            var GRUPOLITORAL = _ctxs.GetGrupoLitoral();
            try
            {
                base.ValidPaginate(page, limit);
                var savedSearches = GRUPOLITORAL.Usuario.Skip(base.skip).OrderBy(o => o.UsuarioId).Take(base.limit);//.Include(x => x.Parameters);



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

        public Task<Usuario> GetById(int id)
        {
            throw new System.NotImplementedException();
        }



        public Task<bool> Update(Usuario usuario)
        {
            throw new System.NotImplementedException();
        }
        public bool ProductExists(int id) => _ctxs.GetGrupoLitoral().Usuario.Any(e => e.UsuarioId == id);

        public Usuario GetByIdAsync(int id)
        {
            var response = new Response<Usuario>();
            try
            {
                var savedSearches = _ctxs.GetGrupoLitoral().Usuario.FirstOrDefaultAsync(x => x.UsuarioId == id);



                return savedSearches.Result;
            }
            catch (Exception e)
            {
                System.Console.WriteLine(e);

                return null;
            }

        }

        public decimal UserValidation(LoginEntity user)
        {

            var exist = _ctxs.GetGrupoLitoral().Usuario.FirstOrDefault(x => x.UsuarioLogin == user.name);
            if (exist != null)
            {
                return exist.UsuarioId;
            }
            else
            {
                return 0;
            }
        }
    }
}