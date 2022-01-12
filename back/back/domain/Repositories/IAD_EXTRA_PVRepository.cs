using System.Threading.Tasks;
using back.domain.DTO.AD_EXTRA_PVDTO;

namespace back.domain.Repositories
{
    public interface IAD_EXTRA_PVRepository
    {
        public Task<AD_EXTRA_PVDTO> GetByNunota(int Nunota);
    }
}