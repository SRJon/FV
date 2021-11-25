using System.Collections.Generic;
using System.Threading.Tasks;
using back.data.entities.VersionDetails;
using back.data.http;
using back.domain.DTO.VersionDetails;

namespace back.domain.Repositories
{
    public interface IVersionDetailsRepository
    {
        public Task<Response<List<VersionDetailsDTO>>> GetAllPaginateAsync(int page, int limit);
        public Task<VersionDetailsDTO> GetById(int id);
        public Task<bool> Create(VersionDetails VersionDetails);
        public Task<bool> Delete(int id);
        public Task<bool> Update(VersionDetails VersionDetails);
    }
}