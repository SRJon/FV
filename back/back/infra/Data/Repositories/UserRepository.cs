using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using back.data.entities.Login;
using back.data.entities.User;
using back.data.http;
using back.domain.DTO.Usuario;
using back.domain.Repositories;
using back.infra.Data.Context;
using back.infra.Services.UsuarioServices;
using back.MappingConfig;
using Microsoft.EntityFrameworkCore;

namespace back.infra.Data.Repositories
{
    public class UserRepository : ValidPagination, IUserRepository
    {
        private readonly IMapper _mapper;
        private readonly DbContexts _ctxs;


        public UserRepository(DbContexts ctxs) : base()
        {
            this._mapper = MapperConfig.MapperConfiguration().CreateMapper();
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
            var GRUPOLITORAL = _ctxs.GetVFU();
            try
            {
                base.ValidPaginate(page, limit);
                var savedSearches = GRUPOLITORAL.Usuario.Skip(base.skip).OrderBy(o => o.Id).Take(base.limit);//.Include(x => x.Parameters);



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

        public async Task<UsuarioDTO> GetById(int id)
        {
            return _mapper.Map<UsuarioDTO>(await this._ctxs
            .GetVFU()
            .GetByIdService(id));
        }



        public Task<bool> Update(Usuario usuario)
        {
            throw new System.NotImplementedException();
        }
        public bool ProductExists(int id) => _ctxs.GetVFU().Usuario.Any(e => e.Id == id);

        public Usuario GetByIdAsync(int id)
        {
            var response = new Response<Usuario>();
            try
            {
                var savedSearches = _ctxs.GetVFU().Usuario.FirstOrDefaultAsync(x => x.Id == id);
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

            var exist = _ctxs.GetVFU().Usuario.FirstOrDefault(x => x.Login == user.name);
            if (exist != null)
            {
                return exist.Id;
            }
            else
            {
                return 0;
            }
        }
    }
}