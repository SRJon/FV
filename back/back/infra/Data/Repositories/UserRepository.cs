using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using back.data.entities.Login;
using back.data.entities.User;
using back.data.http;
using back.domain.DTO.User;
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

        public Task<bool> Create(UsuarioDTOCreate usuario)
        {
            try
            {
                return _ctxs.GetVFU().Create(usuario);
            }
            catch (Exception e)
            {
                return BadRequest(new Response<string>
                {
                    Message = "Erro ao criar usuário",
                    Data = e.Message,
                    Success = false,
                    StatusCode = 400
                });
            }
        }

        public Task<bool> Delete(int id)
        {
            try
            {
                return _ctxs.GetVFU().Delete(id);
            }
            catch (System.Exception e)
            {
                return BadRequest(new Response<string>
                {
                    Message = "Erro ao deletar usuário",
                    Data = e.Message,
                    Success = false,
                    StatusCode = 400
                });
            }
        }

        public async Task<Response<List<UsuarioDTO>>> GetAllPaginateAsync(int page, int limit)
        {
            var response = new Response<List<UsuarioDTO>>();
            var contexto = _ctxs.GetVFU();
            try
            {
                base.ValidPaginate(page, limit);
                var savedSearches = contexto.Usuario.Include(p => p.Perfil).Skip(base.skip).OrderBy(o => o.Id).Take(base.limit);//.Include(x => x.Parameters);

                List<UsuarioDTO> dTOs = new List<UsuarioDTO>();

                var usuarios = await savedSearches.ToListAsync();
                usuarios.ForEach(e => dTOs.Add(_mapper.Map<UsuarioDTO>(e)));


                response.Data = dTOs;
                response.TotalPages = await contexto.Usuario.CountAsync();
                response.Page = page;
                response.TotalPages = base.getTotalPages(response.TotalPages);
                response.Success = true;
                response.StatusCode = 200;
                return response;
            }
            catch (Exception)
            {
                response.Data = null;
                response.StatusCode = 400;
                return response;
            }
        }

        public async Task<UsuarioDTO> GetById(int id)
        {
            var response = await this._ctxs
            .GetVFU()
            .GetByIdUserService(id);
            var result = _mapper.Map<UsuarioDTO>(response);


            return result;
        }

        public async Task<UsuarioWiTHPerfilDTO> GetByIdWithPerfil(int id)
        {
            var response = await this._ctxs
            .GetVFU()
            .GetByIdUserService(id);
            var result = _mapper.Map<UsuarioWiTHPerfilDTO>(response);


            return result;
        }



        public async Task<bool> Update(UsuarioDTOUpdateDTO usuario)
        {
            if (usuario.Id == 0)
            {
                return false;
            }
            return await _ctxs.GetVFU().UpdateUsuarioService(_mapper.Map<UsuarioDTOUpdateDTO>(usuario), usuario.Id);
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
            var exist = _ctxs.GetVFU().Usuario.FirstOrDefault(x => x.Login.ToLower() == user.name.ToLower());
            if (exist != null)
            {
                //Exemplo
                // if (PasswordHash.ValidatePassword(user.password, exist.SenhaFV))
                // {
                //     return exist.Id;
                // }
                return exist.Id;
            }
            else
            {
                return 0;
            }
        }
        private Task<bool> BadRequest(Response<string> response)
        {
            throw new NotImplementedException();
        }

        public async Task<UsuarioDTO> GetByLogin(string login)
        {
            return _mapper.Map<UsuarioDTO>(await this._ctxs
            .GetVFU()
            .GetByLoginService(login));
        }


    }
}