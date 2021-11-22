using System.Collections.Generic;
using System.Threading.Tasks;
using back.data.entities.UserCustomizations;
using back.data.http;
using back.domain.DTO.UserCustomizations;

namespace back.domain.Repositories
{
    public interface IUserCustomizationsRepository
    {
        public Task<Response<List<UserCustomizationsDTO>>> GetAllPaginateAsync(int page, int limit);
        public Task<UserCustomizationsDTO> GetById(int id);
        public Task<bool> Create(UserCustomizations UserCustomizations);
        public Task<bool> Delete(int id);
        public Task<bool> Update(UserCustomizations UserCustomizations);
    }
}