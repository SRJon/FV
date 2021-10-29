using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using back.data.entities.Login;
using back.data.entities.User;
using back.data.http;
using back.domain.Repositories;
using Microsoft.EntityFrameworkCore;

namespace back.infra.Data.Repositories
{
    public class UserRepository : ValidPagination, IUserRepository
    {
        private readonly DbAppContext _ctx;


        public UserRepository(DbAppContext ctx) : base()
        {
            _ctx = ctx;

        }

        public Task<Response<bool>> Create(Usuario usuario)
        {
            throw new System.NotImplementedException();
        }

        public Task<Response<bool>> Delete(int id)
        {
            throw new System.NotImplementedException();
        }

        public async Task<Response<List<Usuario>>> GetAllAsync(int page, int limit)
        {
            var response = new Response<List<Usuario>>();
            try
            {
                base.ValidPaginate(page, limit);
                var savedSearches = _ctx.Usuario.Skip(base.skip).OrderBy(o => o.UsuarioId).Take(base.limit);//.Include(x => x.Parameters);



                response.Data = await savedSearches.ToListAsync();
                response.TotalPages = await _ctx.Usuario.CountAsync();
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

        public Task<Response<Usuario>> GetById(int id)
        {
            throw new System.NotImplementedException();
        }



        public Task<Response<bool>> Update(Usuario usuario)
        {
            throw new System.NotImplementedException();
        }
        public bool ProductExists(int id) => _ctx.Usuario.Any(e => e.UsuarioId == id);

        public Response<Usuario> GetByIdAsync(int id)
        {
            var response = new Response<Usuario>();
            try
            {
                var savedSearches = _ctx.Usuario.FirstOrDefaultAsync(x => x.UsuarioId == id);
                var exist = ProductExists(id);
                if (exist)
                {

                    response.Data = savedSearches.Result;
                    response.Success = true;
                    response.StatusCode = 200;

                }
                else
                {
                    response.Data = null;
                    response.Success = false;
                    response.StatusCode = 404;
                }


                return response;
            }
            catch (Exception e)
            {
                System.Console.WriteLine(e);
                response.Data = null;
                response.StatusCode = 400;
                return response;
            }

        }

        public decimal UserValidation(LoginEntity user)
        {

            var exist = _ctx.Usuario.FirstOrDefault(x => x.UsuarioLogin == user.name);
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